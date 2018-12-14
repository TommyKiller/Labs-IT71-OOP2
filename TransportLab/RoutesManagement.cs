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

namespace TransportLab
{
    public partial class RoutesManagement : Form
    {
        private bool changesSaved = true;
        private BindingList<Route> Routes = new BindingList<Route>();
        private BindingList<Waypoint> Waypoints = new BindingList<Waypoint>();

        public RoutesManagement()
        {
            InitializeComponent();
            // 
            // Data binding 
            // 
            wpList.DataSource = Waypoints;
            routesList.DataSource = Routes;

            EnableRouteEditLayout(false);
            EnableRouteSelectionLayout(true);
            EnableSaveRoute(false);
            EnableSave(false);

            LoadRoutes();
        }

        private void LoadRoutes()
        {
            Routes.Clear();

            foreach (RouteID routeID in CityTransport.Routes.Keys)
            {
                Routes.Add(new Route(CityTransport.Routes[routeID]));
            }

            routesList_SelectedIndexChanged(this, new EventArgs());
        }

        private void LoadWaypoints()
        {
            ClearWaypoints();

            foreach (Waypoint wp in Routes[routesList.SelectedIndex].Waypoints)
            {
                Waypoints.Add(wp);
            }
        }

        private void ClearWaypoints()
        {
            Waypoints.Clear();
            selectedWpAdressIn.Text = string.Empty;
            newWpAdressIn.Text = string.Empty;
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
            if (routesList.SelectedIndex > -1)
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
                deleteRoute.Enabled = true;
            }
            else
            {
                editRoute.Enabled = false;
                deleteRoute.Enabled = false;
            }
        }

        private void createRoute_Click(object sender, EventArgs e)
        {
            if (routeIdIn.Text != string.Empty)
            {
                RouteID routeID = new RouteID(Convert.ToInt32(routeIdIn.Text));
                Route newRoute = new Route(routeID);
                if (!Routes.Contains(newRoute))
                {
                    Routes.Add(newRoute);
                    routeIdIn.Text = string.Empty;
                    routesList.SelectedIndex = routesList.Items.Count - 1;
                    changesSaved = false;
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
            if (routesList.SelectedIndex > -1)
            {
                Routes.Remove(Routes[routesList.SelectedIndex]);
                routesList.SelectedIndex = routesList.Items.Count - 1;
                changesSaved = false;
                EnableSave(true);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!changesSaved)
            {
                EnableSave(false);

                // Adding new and edtiting existing //

                foreach (Route route in Routes)
                {
                    if (!CityTransport.Routes.Keys.Contains(route.ID))
                    {
                        CityTransport.Routes.Add(route.ID, route);
                    }
                    else
                    {
                        CityTransport.Routes[route.ID] = route;
                    }
                }

                // Delete extra routes //

                List<ID> IDList = new List<ID>();
                foreach (RouteID routeID in CityTransport.Routes.Keys)
                {
                    if (!Routes.Contains(CityTransport.Routes[routeID]))
                    {
                        IDList.Add(routeID);
                    }
                }

                foreach (RouteID routeID in IDList)
                {
                    CityTransport.Routes.Remove(routeID);
                }
                
                // Clear assignments to cars //

                foreach (KeyValuePair<CarID, Transport> item in CityTransport.Cars)
                {
                    if ((item.Value as RouteTaxi) != null)
                    {
                        if (((RouteTaxi)item.Value).RouteID != null)
                        {
                            if (!CityTransport.Routes.Keys.Contains(((RouteTaxi)item.Value).RouteID))
                            {
                                ((RouteTaxi)item.Value).RouteID = null;
                            }
                        }
                    }
                }

                changesSaved = true;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (!changesSaved)
            {
                EnableSave(false);
                changesSaved = true;
                LoadRoutes();
            }
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
                selectedWpAdressIn.Text = Waypoints[wpList.SelectedIndex].Adress;
            }
            else
            {
                selectedWpAdressIn.Text = string.Empty;
            }
        }

        private void editSelectedWpAdress_Click(object sender, EventArgs e)
        {
            if (selectedWpAdressIn.Text != string.Empty && wpList.SelectedIndex > -1)
            {
                int index = wpList.SelectedIndex;
                Waypoints.Insert(wpList.SelectedIndex, new Waypoint(selectedWpAdressIn.Text.Trim()));
                Waypoints.Remove(Waypoints[wpList.SelectedIndex]);
                selectedWpAdressIn.Text = string.Empty;
                wpList.SelectedIndex = index;
                EnableSaveRoute(true);
            }
        }

        private void deleteSelectedWp_Click(object sender, EventArgs e)
        {
            if (wpList.SelectedIndex > -1)
            {
                Waypoints.Remove(Waypoints[wpList.SelectedIndex]);
                EnableSaveRoute(true);
            }
        }

        private void addNewWp_Click(object sender, EventArgs e)
        {
            string adress = newWpAdressIn.Text.Trim();
            if (adress != string.Empty)
            {
                Waypoints.Add(new Waypoint(adress));
                newWpAdressIn.Text = string.Empty;
                EnableSaveRoute(true);
            }
        }

        private void up_Click(object sender, EventArgs e)
        {
            if (wpList.SelectedIndex > 0)
            {
                int index = wpList.SelectedIndex;
                Waypoints.Insert(wpList.SelectedIndex - 1, Waypoints[wpList.SelectedIndex]);
                Waypoints.RemoveAt(wpList.SelectedIndex);
                wpList.SelectedIndex = index - 1;
                EnableSaveRoute(true);
            }
        }

        private void down_Click(object sender, EventArgs e)
        {
            if (wpList.Items.Count > 1 && wpList.SelectedIndex < wpList.Items.Count - 1)
            {
                int index = wpList.SelectedIndex;
                Waypoints.Insert(wpList.SelectedIndex + 2, Waypoints[wpList.SelectedIndex]);
                Waypoints.RemoveAt(wpList.SelectedIndex);
                wpList.SelectedIndex = index + 1;
                EnableSaveRoute(true);
            }
        }

        private void saveRoute_Click(object sender, EventArgs e)
        {
            EnableSaveRoute(false);
            Routes[routesList.SelectedIndex].Waypoints.Clear();

            foreach (Waypoint wp in Waypoints)
            {
                Routes[routesList.SelectedIndex].AddWaypoint(wp);
            }

            changesSaved = false;
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
                EnableRouteSelectionLayout(true);
                EnableRouteEditLayout(false);
                if (!changesSaved)
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
