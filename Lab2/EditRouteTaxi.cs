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
        private RouteTaxi car;

        public EditRouteTaxi(RouteTaxi car = null)
        {
            InitializeComponent();

            Car = car;
            routesList.DropDownStyle = ComboBoxStyle.DropDownList;
            saveChanges.Enabled = false;
            LoadRoutes();
        }

        private void LoadRoutes()
        {
            routesList.Items.Clear();

            int index = -1;
            foreach (ID id in CityTransport.Routes.Keys)
            {
                routesList.Items.Add(CityTransport.Routes[id]);
                ++index;
            }

            routesList.SelectedIndex = index;
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

        // Car editor //

        private void carCompanyIn_TextChanged(object sender, EventArgs e)
        {
            if (!saveChanges.Enabled)
            {
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
            ClearWaypoints();
            LoadWaypoints();
        }

        private void fuelCapacityIn_TextChanged(object sender, EventArgs e)
        {
            if (!saveChanges.Enabled)
            {
                saveChanges.Enabled = true;
            }
        }

        private void fuelConsumptionIn_TextChanged(object sender, EventArgs e)
        {
            if (!saveChanges.Enabled)
            {
                saveChanges.Enabled = true;
            }
        }

        private void carIDIn_TextChanged(object sender, EventArgs e)
        {
            if (!saveChanges.Enabled)
            {
                saveChanges.Enabled = true;
            }
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            if (carIDIn.Text != string.Empty && carCompanyIn.Text != string.Empty &&
                fuelCapacityIn.Text != string.Empty && fuelConsumptionIn.Text != string.Empty &&
                routesList.SelectedItem != null && routesList.SelectedItem != null)
            {
                ID ID = new ID(Convert.ToInt32(carIDIn.Text));
                if (((Route)routesList.SelectedItem).Waypoints.First() == ((Route)routesList.SelectedItem).Waypoints.Last())
                {
                    CircularRouteTaxi car = new CircularRouteTaxi(ID, carCompanyIn.Text.Trim(), (Route)routesList.SelectedItem,
                        Convert.ToInt32(fuelCapacityIn.Text), Convert.ToInt32(fuelConsumptionIn.Text));
                    CityTransport.Cars.Add(ID, car);
                }
                else
                {
                    DirectRouteTaxi car = new DirectRouteTaxi(ID, carCompanyIn.Text, (Route)routesList.SelectedItem,
                        Convert.ToInt32(fuelCapacityIn.Text), Convert.ToInt32(fuelConsumptionIn.Text));
                    CityTransport.Cars.Add(ID, car);
                }

                Close();
            }
            else
            {
                MessageBox.Show("Input data please!");
            }
        }

        private void cancelChanges_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
