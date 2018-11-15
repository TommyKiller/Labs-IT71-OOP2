using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class CarsManagement : Form
    {
        private bool carsChanged = false;
        public CarsManagement()
        {
            InitializeComponent();

            carsList.DropDownStyle = ComboBoxStyle.DropDownList;
            routesList.DropDownStyle = ComboBoxStyle.DropDownList;
            EnableCarsEditLayout(false);
            EnableCarsSelectionLayout(true);
            applyChanges.Enabled = false;
            EnableSave(false);
            LoadCars();
        }

        private void LoadCars()
        {
            carsList.Items.Clear();

            foreach (ID id in CityTransport.Cars.Keys)
            {
                carsList.Items.Add(CityTransport.Cars[id]);

            }

            if (carsList.Items.Count > 0)
            {
                carsList.SelectedIndex = 0;
            }
            else
            {
                carsList.SelectedIndex = -1;
            }
        }

        private void LoadRoutes()
        {
            routesList.Items.Clear();

            int index = -1;
            foreach (ID id in CityTransport.Routes.Keys)
            {
                routesList.Items.Add(CityTransport.Routes[id]);
                if (CityTransport.Routes[id] == ((Transport)carsList.SelectedItem).Route)
                {
                    routesList.SelectedIndex = index;
                }
                ++index;
            }

            routesList.SelectedIndex = index;
        }

        private void ClearRoutes()
        {
            routesList.Items.Clear();
            routesList.SelectedIndex = -1;
        }

        private void LoadWaypoints()
        {
            wpList.Items.Clear();

            foreach (Waypoint wp in ((Route)routesList.SelectedItem).Waypoints)
            {
                wpList.Items.Add(wp);
            }
        }

        private void ClearWaypoints()
        {
            wpList.Items.Clear();
            wpList.SelectedIndex = -1;
        }

        private void FillData(Transport car)
        {
            FuelPoweredTransport fuelCar = car as FuelPoweredTransport;
            if (fuelCar != null)
            {
                carID.Text += fuelCar.ID.ToString();
                carCompanyIn.Text = fuelCar.Company;
                fuelConsumptionIn.Text = fuelCar.FuelConsumption.ToString();
                fuelCapacityIn.Text = fuelCar.FuelCapacity.ToString();
            }
        }

        private void ClearData()
        {
            carID.Text = "Car ID: ";
            carCompanyIn.Text = string.Empty;
            fuelConsumptionIn.Text = string.Empty;
            fuelCapacityIn.Text = string.Empty;
        }

        private bool CheckRoute(Route route)
        {
            if ((carsList.SelectedItem as CircularRouteTaxi) != null)
            {
                if (route.Waypoints.First() == route.Waypoints.Last())
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Incorrect route!");
                    return false;
                }
            }
            else if((carsList.SelectedItem as DirectRouteTaxi) != null)
            {
                if (route.Waypoints.First() != route.Waypoints.Last())
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Incorrect route!");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        // Buttnos enabling //

        private void EnableCarsSelectionLayout(bool mode)
        {
            editCar.Enabled = mode;
            deleteCar.Enabled = mode;
            newCar.Enabled = mode;
            exit.Enabled = mode;
        }

        private void EnableCarsEditLayout(bool mode)
        {
            routesList.Enabled = mode;
            carCompanyIn.Enabled = mode;
            fuelCapacityIn.Enabled = mode;
            fuelConsumptionIn.Enabled = mode;
        }

        private void EnableSave(bool mode)
        {
            save.Enabled = mode;
            cancel.Enabled = mode;
        }

        // Car selection //

        private void editCar_Click(object sender, EventArgs e)
        {
            if (carsList.SelectedItem != null)
            {
                EnableCarsSelectionLayout(false);
                EnableCarsEditLayout(true);
                cancelChanges.Enabled = true;
                EnableSave(false);
                FillData((Transport)carsList.SelectedItem);
                LoadRoutes();
            }
        }

        private void newCar_Click(object sender, EventArgs e)
        {
            Form registerCar = new RegisterCarForm();
            registerCar.ShowDialog();
            carsChanged = true;
            LoadCars();
        }

        private void deleteCar_Click(object sender, EventArgs e)
        {
            if (carsList.SelectedItem != null)
            {
                int index = carsList.SelectedIndex;
                carsList.Items.Remove(carsList.SelectedItem);
                carsList.SelectedIndex = index - 1;
                carsChanged = true;
                EnableSave(true);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            EnableSave(false);
            carsChanged = false;
            LoadCars();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            CityTransport.Context.MainForm = new MainMenu();
            Close();
            CityTransport.Context.MainForm.Show();
        }

        // Car editor //

        private void carCompanyIn_TextChanged(object sender, EventArgs e)
        {
            if (!applyChanges.Enabled)
            {
                applyChanges.Enabled = true;
            }
        }

        private void carCompanyIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void digitsIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void routesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearWaypoints();
            LoadWaypoints();

            if (((Route)routesList.SelectedItem).Equals(((Transport)carsList.SelectedItem).Route))
            {
                if (!applyChanges.Enabled)
                {
                    applyChanges.Enabled = true;
                }
            }
        }

        private void fuelCapacityIn_TextChanged(object sender, EventArgs e)
        {
            if (!applyChanges.Enabled)
            {
                applyChanges.Enabled = true;
            }
        }

        private void fuelConsumptionIn_TextChanged(object sender, EventArgs e)
        {
            if (!applyChanges.Enabled)
            {
                applyChanges.Enabled = true;
            }
        }

        private void applyChanges_Click(object sender, EventArgs e)
        {
            if (carCompanyIn.Text != string.Empty &&
                fuelCapacityIn.Text != string.Empty && fuelConsumptionIn.Text != string.Empty &&
                routesList.SelectedItem != null)
            {
                if (CheckRoute((Route)routesList.SelectedItem))
                {
                    ((FuelPoweredTransport)carsList.SelectedItem).Company = carCompanyIn.Text.Trim();
                    ((FuelPoweredTransport)carsList.SelectedItem).FuelCapacity = Convert.ToInt32(fuelCapacityIn.Text);
                    ((FuelPoweredTransport)carsList.SelectedItem).FuelConsumption = Convert.ToInt32(fuelConsumptionIn.Text);
                    ((FuelPoweredTransport)carsList.SelectedItem).Route = CityTransport.Routes[((Route)routesList.SelectedItem).ID];
                    carsChanged = true;
                    applyChanges.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Incorrect route!");
                }
            }
            else
            {
                MessageBox.Show("Input data, please!");
            }
        }

        private void cancelChanges_Click(object sender, EventArgs e)
        {
            if (((Transport)carsList.SelectedItem).Route != null)
            {
                ClearWaypoints();
                ClearRoutes();
                ClearData();
                EnableCarsEditLayout(false);
                applyChanges.Enabled = false;
                cancelChanges.Enabled = false;
                EnableCarsSelectionLayout(true);
                if (carsChanged)
                {
                    EnableSave(true);
                }
            }
            else
            {
                MessageBox.Show("You must assign route to the car!");
            }
        }
    }
}
