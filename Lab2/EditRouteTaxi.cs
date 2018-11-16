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
    public partial class EditRouteTaxi : Form
    {
        private bool changesSaved = true;
        private List<ID> CarsIDList { get; }
        private RouteTaxi car;
        public RouteTaxi Car
        {
            get
            {
                return car;
            }
            set
            {
                car = (value as RouteTaxi != null) ? value : null;
            }
        }

        public EditRouteTaxi(List<ID> carsIDList, string caption, RouteTaxi car = null)
        {
            InitializeComponent();

            CarsIDList = carsIDList;
            Text = caption;
            Car = car;
            routesList.DropDownStyle = ComboBoxStyle.DropDownList;
            typesList.DropDownStyle = ComboBoxStyle.DropDownList;
            typesList.Items.Add("Circular");
            typesList.Items.Add("Direct");
            FillData();
            saveChanges.Enabled = false;
        }

        private void LoadRoutes()
        {
            routesList.Items.Clear();

            switch (typesList.SelectedItem.ToString())
            {
                case "Circular":
                    foreach (ID id in CityTransport.Routes.Keys)
                    {
                        if (CityTransport.Routes[id].Waypoints.First() == CityTransport.Routes[id].Waypoints.Last())
                        {
                            routesList.Items.Add(CityTransport.Routes[id]);
                        }
                    }
                    break;
                case "Direct":
                    foreach (ID id in CityTransport.Routes.Keys)
                    {
                        if (!(CityTransport.Routes[id].Waypoints.First() == CityTransport.Routes[id].Waypoints.Last()))
                        {
                            routesList.Items.Add(CityTransport.Routes[id]);
                        }
                    }
                    break;
            }

            routesList.SelectedIndex = routesList.Items.Count - 1;
        }

        private void LoadWaypoints()
        {
            wpList.Items.Clear();

            foreach (Waypoint wp in ((Route)routesList.SelectedItem).Waypoints)
            {
                wpList.Items.Add(wp);
            }
        }

        private void FillData()
        {
            if (Car != null)
            {
                MessageBox.Show(Car.GetType().ToString().Split(new char[] { '.' }).Last());
                switch (Car.GetType().ToString().Split(new char[] { '.' }).Last())
                {
                    case "CircularRouteTaxi":
                        typesList.SelectedIndex = 0;
                        break;
                    case "DirectRouteTaxi":
                        typesList.SelectedIndex = 1;
                        break;
                }
                typesList.Enabled = false;
                carIDIn.Text = Car.ID.ToString();
                carIDIn.Enabled = false;
                carCompanyIn.Text = Car.Company;
                fuelCapacityIn.Text = Car.FuelCapacity.ToString();
                fuelConsumptionIn.Text = Car.FuelConsumption.ToString();
            }
        }

        private bool CheckInput()
        {
            if (carIDIn.Text == string.Empty)
                throw new Exception("Enter car's ID!");
            if (CarsIDList.Contains(new ID(Convert.ToInt32(carIDIn.Text))))
                throw new Exception("Car with that ID already exists!");
            if (carCompanyIn.Text == string.Empty)
                throw new Exception("Enter car's company name!");
            if (fuelCapacityIn.Text == string.Empty)
                throw new Exception("Enter car's fuel capacity!");
            if (fuelConsumptionIn.Text == string.Empty)
                throw new Exception("Enter car's fuel consumption rate!");
            if (Convert.ToInt32(fuelConsumptionIn.Text) > Convert.ToInt32(fuelCapacityIn.Text))
                throw new Exception("Fuel consumption rate of the car can't be more then it's fuel capacity!");
            if (typesList.SelectedItem == null)
                throw new Exception("Choose type of the route!");
            if (routesList.SelectedItem == null)
                throw new Exception("Choose route!");
            return true;
        }

        // Car editor //

        private void carCompanyIn_TextChanged(object sender, EventArgs e)
        {
            if (!saveChanges.Enabled)
            {
                changesSaved = false;
                saveChanges.Enabled = true;
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
            LoadWaypoints();
        }

        private void fuelCapacityIn_TextChanged(object sender, EventArgs e)
        {
            if (!saveChanges.Enabled)
            {
                changesSaved = false;
                saveChanges.Enabled = true;
            }
        }

        private void fuelConsumptionIn_TextChanged(object sender, EventArgs e)
        {
            if (!saveChanges.Enabled)
            {
                changesSaved = false;
                saveChanges.Enabled = true;
            }
        }

        private void carIDIn_TextChanged(object sender, EventArgs e)
        {
            if (!saveChanges.Enabled)
            {
                changesSaved = false;
                saveChanges.Enabled = true;
            }
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            if (!changesSaved)
            {
                try
                {
                    if (CheckInput())
                    {
                        ID routeID = ((Route)routesList.SelectedItem).ID;
                        string company = carCompanyIn.Text.Trim();
                        int fuelCapacity = Convert.ToInt32(fuelCapacityIn.Text);
                        int fuelConsumption = Convert.ToInt32(fuelConsumptionIn.Text);

                        if (Car == null)
                        {
                            ID carID = new ID(Convert.ToInt32(carIDIn.Text));
                            switch (typesList.SelectedItem.ToString())
                            {
                                case "Circular":
                                    Car = new CircularRouteTaxi(carID, company, CityTransport.Routes[routeID], fuelCapacity, fuelConsumption);
                                    break;
                                case "Direct":
                                    Car = new DirectRouteTaxi(carID, company, CityTransport.Routes[routeID], fuelCapacity, fuelConsumption);
                                    break;
                            }
                        }
                        else
                        {
                            Car.Company = company;
                            Car.FuelCapacity = fuelCapacity;
                            Car.FuelConsumption = fuelConsumption;
                            Car.Route = CityTransport.Routes[routeID];
                        }

                        changesSaved = true;
                        saveChanges.Enabled = false;
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void cancelChanges_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void typesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRoutes();
        }
    }
}
