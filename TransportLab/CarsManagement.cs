using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using TransportLibrary;

namespace TransportLab
{
    public partial class CarsManagement : Form
    {
        private bool changesSaved = true;
        private BindingList<Transport> Cars = new BindingList<Transport>();

        public CarsManagement()
        {
            InitializeComponent();
            // 
            // Data bindings 
            // 
            carsList.DataSource = Cars;

            SetTypes();
            EnableSave(false);
            LoadCars();
        }

        private void SetTypes()
        {
            typesList.Items.Add("Route taxi");
        }

        private void LoadCars()
        {
            Cars.Clear();

            foreach(CarID carID in Transport.Cars.Keys)
            {
                if ((Transport.Cars[carID] as RouteTaxi) != null)
                {
                    Cars.Add(new RouteTaxi(Transport.Cars[carID] as RouteTaxi));
                }
            }

            carsList_SelectedIndexChanged(this, new EventArgs());
        }

        private void EnableSave(bool mode)
        {
            save.Enabled = mode;
            cancel.Enabled = mode;
        }

        private void newCar_Click(object sender, EventArgs e)
        {
            List<CarID> carsIDList = new List<CarID>();
            foreach (Transport car in Cars)
            {
                carsIDList.Add(car.ID);
            }

            switch (typesList.Text)
            {
                case "Route taxi":
                    EditRouteTaxi editRouteTaxi = new EditRouteTaxi(carsIDList, "Register car");
                    editRouteTaxi.ShowDialog();
                    if (editRouteTaxi.IsHandled)
                    {
                        Cars.Add(editRouteTaxi.Car);
                        carsList.SelectedIndex = Cars.Count - 1;
                        carsList_SelectedIndexChanged(this, new EventArgs());
                        changesSaved = false;
                        EnableSave(true);
                    }
                    break;
            }
        }

        private void editCar_Click(object sender, EventArgs e)
        {
            if (carsList.SelectedIndex > -1)
            {
                int index = carsList.SelectedIndex;
                List<CarID> carsIDList = new List<CarID>();
                foreach (Transport car in Cars)
                {
                    carsIDList.Add(car.ID);
                }

                if ((Cars[index] as RouteTaxi) != null)
                {
                    EditRouteTaxi editRouteTaxi = new EditRouteTaxi(carsIDList, "Edit car", (RouteTaxi)Cars[index]);
                    editRouteTaxi.ShowDialog();
                    if (editRouteTaxi.IsHandled)
                    {
                        Cars[index] = new RouteTaxi(editRouteTaxi.Car);

                        carsList.SelectedIndex = Cars.Count - 1;
                        carsList_SelectedIndexChanged(this, new EventArgs());
                        changesSaved = false;
                        EnableSave(true);
                    }
                }
            }
        }

        private void deleteCar_Click(object sender, EventArgs e)
        {
            if (carsList.SelectedIndex > -1)
            {
                Cars.Remove(Cars[carsList.SelectedIndex]);
                changesSaved = false;
                EnableSave(true);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!changesSaved)
            {
                // Adding new and edtiting existing //

                foreach (Transport car in Cars)
                {
                    if (!Transport.Cars.Keys.Contains(car.ID))
                    {
                        Transport.Cars.Add(car.ID, car);
                    }
                    else
                    {
                        Transport.Cars[car.ID] = car;
                    }
                }
                
                // Delete extra cars //

                List<CarID> IDList = new List<CarID>();
                foreach (CarID carID in Transport.Cars.Keys)
                {
                    if (!Cars.Contains(Transport.Cars[carID]))
                    {
                        IDList.Add(carID);
                    }
                }

                foreach (CarID carID in IDList)
                {
                    Transport.Cars.Remove(carID);
                }

                EnableSave(false);
                changesSaved = true;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (!changesSaved)
            {
                EnableSave(false);
                changesSaved = true;
                LoadCars();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            CityTransport.Context.MainForm = new MainMenu();
            Close();
            CityTransport.Context.MainForm.Show();
        }

        private void carsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carsList.SelectedIndex > -1)
            {
                editCar.Enabled = true;
                deleteCar.Enabled = true;
            }
            else
            {
                editCar.Enabled = false;
                deleteCar.Enabled = false;
            }
        }
    }
}
