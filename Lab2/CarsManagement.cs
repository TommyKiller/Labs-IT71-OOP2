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
        public CarsManagement()
        {
            InitializeComponent();

            carsList.DropDownStyle = ComboBoxStyle.DropDownList;
            routesList.DropDownStyle = ComboBoxStyle.DropDownList;
            EnableRouteEditLayout(false);
            EnableRouteSelectionLayout(true);
            EnableSaveRoute(false);
            EnableSave(false);
            LoadRoutes();
        }

        private void LoadRoutes()
        {
            routesList.Items.Clear();

            int index = 0;
            foreach (ID id in Transport.Routes.Keys)
            {
                routesList.Items.Add(Transport.Routes[id]);
                if (Transport.Routes[id] == ((CityTransport)carsList.SelectedItem).Route)
                {
                    routesList.SelectedIndex = index;
                }
                ++index;
            }
        }

        private void LoadWaypoints()
        {
            wpList.Items.Clear();

            foreach (Waypoint wp in ((Route)routesList.SelectedItem).Waypoints)
            {
                wpList.Items.Add(wp);
            }
        }

        private void editCar_Click(object sender, EventArgs e)
        {
            if (carsList.SelectedItem != null)
            {
                EnableRouteSelectionLayout(false);
                EnableRouteEditLayout(true);
                EnableSave(false);
                LoadWaypoints();
            }
        }

        private void deleteCar_Click(object sender, EventArgs e)
        {
            if (carsList.SelectedItem != null)
            {
                int index = carsList.SelectedIndex;
                carsList.Items.Remove(carsList.SelectedItem);
                carsList.SelectedIndex = index - 1;
                routesChanged = true;
                EnableSave(true);
            }
        }
    }
}
