using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportLibrary;

namespace Lab2
{
    public partial class EditRouteTaxi : Form
    {
        private bool changesSaved = true;
        private List<CarID> CarsIDList { get; }
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

        public EditRouteTaxi(List<CarID> carsIDList, string caption, RouteTaxi car = null)
        {
            InitializeComponent();

            CarsIDList = carsIDList;
            Text = caption;
            Car = car;

            SetTypes();
            FillData();
        }

        private void SetTypes()
        {
            typesList.Items.Add(RouteTypes.Circular);
            typesList.Items.Add(RouteTypes.Direct);
        }

        private void LoadRoutes()
        {
            routesList.Items.Clear();
            int index = -1;

            foreach (RouteID RouteID in CityTransport.Routes.Keys)
            {
                if ((RouteTypes)typesList.SelectedValue == CityTransport.Routes[RouteID].RouteType)
                {
                    ++index;
                    routesList.Items.Add(CityTransport.Routes[RouteID]);
                    if ((Car != null) && (Car.RouteID != null))
                    {
                        if (CityTransport.Routes[RouteID].ID == Car.RouteID)
                        {
                            routesList.SelectedIndex = index;
                        }
                    }
                }
            }

            wpList.Items.Clear();

            if (routesList.SelectedIndex < 0)
            {
                routesList.SelectedIndex = routesList.Items.Count - 1;
            }

            routesList_SelectedIndexChanged(this, new EventArgs());
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
                foreach (RouteTypes type in typesList.Items.Cast<RouteTypes>())
                {
                    if (CityTransport.Routes[Car.RouteID].RouteType == type)
                    {
                        typesList.SelectedItem = type;
                        break;
                    }
                }
                typesList.Enabled = false;
                carIDIn.Text = Car.ID.ToString();
                carIDIn.Enabled = false;
                carCompanyIn.Text = Car.Company;
                fuelCapacityIn.Text = Car.FuelCapacity.ToString();
                fuelCapacityIn.Enabled = false;
                fuelConsumptionIn.Text = Car.FuelConsumption.ToString();
                fuelCapacityIn.Enabled = false;
            }
        }

        private bool CheckInput()
        {
            if (carIDIn.Text == string.Empty)
                throw new Exception("Enter car's ID!");
            CarID carID = new CarID(Convert.ToInt32(carIDIn.Text));
            if (Car == null)
            {
                if (CarsIDList.Contains(carID))
                    throw new Exception("Car with that ID already exists!");
            }
            else
            {
                if (CarsIDList.Contains(carID) && (Car.ID != carID))
                    throw new Exception("Car with that ID already exists!");
            }
            if (carCompanyIn.Text.Trim() == string.Empty)
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
            if (changesSaved)
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
            if (routesList.SelectedIndex > -1)
            {
                LoadWaypoints();

                if (changesSaved)
                {
                    changesSaved = false;
                    saveChanges.Enabled = true;
                }
            }
        }

        private void fuelCapacityIn_TextChanged(object sender, EventArgs e)
        {
            if (changesSaved)
            {
                changesSaved = false;
                saveChanges.Enabled = true;
            }
        }

        private void fuelConsumptionIn_TextChanged(object sender, EventArgs e)
        {
            if (changesSaved)
            {
                changesSaved = false;
                saveChanges.Enabled = true;
            }
        }

        private void carIDIn_TextChanged(object sender, EventArgs e)
        {
            if (changesSaved)
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
                        RouteID routeID = ((Route)routesList.SelectedItem).ID;
                        string company = carCompanyIn.Text.Trim();
                        int fuelCapacity = Convert.ToInt32(fuelCapacityIn.Text);
                        int fuelConsumption = Convert.ToInt32(fuelConsumptionIn.Text);

                        if (Car == null)
                        {
                            CarID carID = new CarID(Convert.ToInt32(carIDIn.Text));
                            Car = new RouteTaxi(carID, company, routeID, fuelCapacity, fuelConsumption);
                        }
                        else
                        {
                            Car.Company = company;
                            Car.RouteID = routeID;
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
