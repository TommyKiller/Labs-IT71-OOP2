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
    public partial class RoutesManagement : Form
    {
        private bool routesChanged = false;

        public RoutesManagement()
        {
            InitializeComponent();

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

            foreach (ID id in CityTransport.Routes.Keys)
            {
                routesList.Items.Add(CityTransport.Routes[id]);
            }

            if (routesList.Items.Count > 0)
            {
                routesList.SelectedIndex = 0;
            }
            else
            {
                routesList.SelectedIndex = -1;
            }
        }

        private void LoadWaypoints()
        {
            ClearWaypoints();

            foreach (Waypoint wp in ((Route)routesList.SelectedItem).Waypoints)
            {
                wpList.Items.Add(wp);
            }
        }

        private void ClearWaypoints()
        {
            wpList.Items.Clear();
            wpList.SelectedIndex = -1;
            selectedWpAdressIn.Text = string.Empty;
        }

        // Buttnos enabling //

        private void EnableRouteSelectionLayout(bool mode)
        {
            routesList.Enabled = mode;
            routeIdIn.Enabled = mode;
            editRoute.Enabled = mode;
            deleteRoute.Enabled = mode;
            addNewRoute.Enabled = mode;
            back.Enabled = mode;
        }

        private void EnableRouteEditLayout(bool mode)
        {
            newWpAdressIn.Enabled = mode;
            selectedWpAdressIn.Enabled = mode;
            addNewWp.Enabled = mode;
            editWp.Enabled = mode;
            deleteWp.Enabled = mode;
            exitRoute.Enabled = mode;
            up.Enabled = mode;
            down.Enabled = mode;
        }

        private void EnableSave(bool mode)
        {
            save.Enabled = mode;
            cancel.Enabled = mode;
        }

        private void EnableSaveRoute(bool mode)
        {
            saveRoute.Enabled = mode;
            cancelRoute.Enabled = mode;
        }

        // Route selection //

        private void editRoute_Click(object sender, EventArgs e)
        {
            if (routesList.SelectedItem != null)
            {
                EnableRouteSelectionLayout(false);
                EnableRouteEditLayout(true);
                EnableSave(false);
                LoadWaypoints();
            }
        }

        private void routesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (routesList.SelectedIndex > -1)
            {
                editRoute.Enabled = true;
            }
            else
            {
                editRoute.Enabled = false;
            }
        }

        private void createRoute_Click(object sender, EventArgs e)
        {
            if (routeIdIn.Text != string.Empty)
            {
                ID routeID = new ID(Convert.ToInt32(routeIdIn.Text));
                Route newRoute = new Route(routeID);
                if (!routesList.Items.Contains(newRoute))
                {
                    routesList.Items.Add(newRoute);
                    routeIdIn.Text = string.Empty;
                    routesList.SelectedIndex = routesList.Items.Count - 1;
                    routesChanged = true;
                    EnableRouteSelectionLayout(false);
                    EnableRouteEditLayout(true);
                    EnableSave(false);
                }
                else
                {
                    MessageBox.Show("Route with that ID already exists!");
                }
            }
        }

        private void routeIdIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void deleteRoute_Click(object sender, EventArgs e)
        {
            if (routesList.SelectedItem != null)
            {
                int index = routesList.SelectedIndex;
                foreach (ID id in CityTransport.Cars.Keys)
                {
                    if (CityTransport.Cars[id].Route == (Route)routesList.SelectedItem)
                    {
                        CityTransport.Cars[id].Route = null;
                    }
                }
                routesList.Items.Remove(routesList.SelectedItem);
                routesList.SelectedIndex = index - 1;
                routesChanged = true;
                EnableSave(true);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            EnableSave(false);

            Dictionary<ID, Route> localRoutes = new Dictionary<ID, Route>();
            foreach (Route route in routesList.Items.Cast<Route>())
            {
                localRoutes.Add(route.ID, route);
            }

            foreach (Route route in routesList.Items.Cast<Route>())
            {
                int count = 0;

                foreach (ID id in CityTransport.Routes.Keys)
                {
                    if (CityTransport.Routes[id].Equals(route))
                    {
                        ++count;
                        CityTransport.Routes[id].Waypoints.Clear();

                        foreach (Waypoint wp in route.Waypoints)
                        {
                            CityTransport.Routes[id].Waypoints.Add(wp);
                        }
                    }
                }

                if (count == 0)
                {
                    CityTransport.Routes.Add(route.ID, route);
                }
            }

            Dictionary<ID, Route> tempDict = new Dictionary<ID, Route>();

            foreach (KeyValuePair<ID, Route> item in CityTransport.Routes)
            {
                if (!localRoutes.Contains(item))
                {
                    tempDict.Add(item.Key, item.Value);
                }
            }

            foreach (ID id in tempDict.Keys)
            {
                CityTransport.Routes.Remove(id);
            }

            routesChanged = false;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            EnableSave(false);
            routesChanged = false;
            LoadRoutes();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            CityTransport.Context.MainForm = new MainMenu();
            Close();
            CityTransport.Context.MainForm.Show();
        }

        // Route editor //

        private void wpAdressIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void wpList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (wpList.SelectedIndex > -1)
            {
                selectedWpAdressIn.Text = ((Waypoint)wpList.SelectedItem).Adress;
            }
            else
            {
                selectedWpAdressIn.Text = string.Empty;
            }
        }

        private void editSelectedWpAdress_Click(object sender, EventArgs e)
        {
            if (selectedWpAdressIn.Text != string.Empty && wpList.SelectedItem != null)
            {
                wpList.Items.Insert(wpList.SelectedIndex, new Waypoint(selectedWpAdressIn.Text.Trim()));
                wpList.Items.Remove(wpList.SelectedItem);
                selectedWpAdressIn.Text = string.Empty;
                EnableSaveRoute(true);
            }
        }

        private void deleteSelectedWp_Click(object sender, EventArgs e)
        {
            if (wpList.SelectedItem != null)
            {
                wpList.Items.Remove(wpList.SelectedItem);
                EnableSaveRoute(true);
            }
        }

        private void addNewWp_Click(object sender, EventArgs e)
        {
            if (newWpAdressIn.Text != string.Empty)
            {
                wpList.Items.Add(new Waypoint(newWpAdressIn.Text.Trim()));
                newWpAdressIn.Text = string.Empty;
                EnableSaveRoute(true);
            }
        }

        private void up_Click(object sender, EventArgs e)
        {
            if (wpList.SelectedIndex > 0)
            {
                int index = wpList.SelectedIndex;
                wpList.Items.Insert(wpList.SelectedIndex - 1, wpList.SelectedItem);
                wpList.Items.RemoveAt(wpList.SelectedIndex);
                wpList.SelectedIndex = index - 1;
                EnableSaveRoute(true);
            }
        }

        private void down_Click(object sender, EventArgs e)
        {
            if (wpList.Items.Count > 1 && wpList.SelectedIndex < wpList.Items.Count - 1)
            {
                int index = wpList.SelectedIndex;
                wpList.Items.Insert(wpList.SelectedIndex + 2, wpList.SelectedItem);
                wpList.Items.RemoveAt(wpList.SelectedIndex);
                wpList.SelectedIndex = index + 1;
                EnableSaveRoute(true);
            }
        }

        private void saveRoute_Click(object sender, EventArgs e)
        {
            EnableSaveRoute(false);
            ((Route)routesList.SelectedItem).Waypoints.Clear();

            foreach (Waypoint wp in wpList.Items.Cast<Waypoint>())
            {
                ((Route)routesList.SelectedItem).Waypoints.Add(wp);
            }

            routesChanged = true;
        }

        private void cancelRoute_Click(object sender, EventArgs e)
        {
            EnableSaveRoute(false);
            LoadWaypoints();
        }

        private void exitRoute_Click(object sender, EventArgs e)
        {
            if (saveRoute.Enabled)
            {
                if (MessageBox.Show("Youe have unsaved changes! Do you want to save them?",
                    "Save changes?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    saveRoute_Click(sender, e);
                }
                else
                {
                    cancelRoute_Click(sender, e);
                }
            }

            if (wpList.Items.Count > 1)
            {
                ClearWaypoints();
                newWpAdressIn.Text = string.Empty;
                EnableRouteSelectionLayout(true);
                EnableRouteEditLayout(false);
                if (routesChanged)
                {
                    EnableSave(true);
                }
            }
            else
            {
                MessageBox.Show("Every route must have at least 2 waypoints!");
            }
        }
    }
}
