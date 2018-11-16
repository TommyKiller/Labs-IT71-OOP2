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
        private bool changesSaved = true;

        public CarsManagement()
        {
            InitializeComponent();

            carsList.DropDownStyle = ComboBoxStyle.DropDownList;
            typesList.DropDownStyle = ComboBoxStyle.DropDownList;
            typesList.Items.Add("Route taxi");
            EnableSave(false);
            LoadCars();
        }

        private void LoadCars()
        {
            carsList.Items.Clear();

            foreach(ID id in CityTransport.Cars.Keys)
            {
                carsList.Items.Add(CityTransport.Cars[id]);
            }

            carsList.SelectedIndex = carsList.Items.Count - 1;
        }

        private void EnableSave(bool mode)
        {
            save.Enabled = mode;
            cancel.Enabled = mode;
        }

        private void newCar_Click(object sender, EventArgs e)
        {
            List<ID> carsIDList = new List<ID>();
            foreach (Transport car in carsList.Items.Cast<Transport>())
            {
                carsIDList.Add(car.ID);
            }

            switch (typesList.Text)
            {
                case "Route taxi":
                    EditRouteTaxi editRouteTaxi = new EditRouteTaxi(carsIDList, "Register car");
                    editRouteTaxi.ShowDialog();
                    if (editRouteTaxi.Car != null)
                    {
                        carsList.Items.Add(editRouteTaxi.Car);
                        changesSaved = false;
                        EnableSave(true);
                    }
                    break;
            }
        }

        private void editCar_Click(object sender, EventArgs e)
        {
            if (carsList.SelectedItem != null)
            {
                if ((carsList.SelectedItem as RouteTaxi) != null)
                {
                    List<ID> carsIDList = new List<ID>();
                    foreach (Transport car in carsList.Items.Cast<Transport>())
                    {
                        carsIDList.Add(car.ID);
                    }

                    EditRouteTaxi editRouteTaxi = new EditRouteTaxi(carsIDList, "Edit car", (RouteTaxi)carsList.SelectedItem);
                    editRouteTaxi.ShowDialog();
                    if (editRouteTaxi.Car != null)
                    {
                        ((RouteTaxi)carsList.SelectedItem).Company = editRouteTaxi.Car.Company;
                        ((RouteTaxi)carsList.SelectedItem).FuelCapacity = editRouteTaxi.Car.FuelCapacity;
                        ((RouteTaxi)carsList.SelectedItem).FuelConsumption = editRouteTaxi.Car.FuelConsumption;
                        ((RouteTaxi)carsList.SelectedItem).Route = editRouteTaxi.Car.Route;
                        changesSaved = false;
                        EnableSave(true);
                    }
                }
            }
        }

        private void deleteCar_Click(object sender, EventArgs e)
        {
            if (carsList.SelectedItem != null)
            {
                carsList.Items.Remove(carsList.SelectedItem);
                carsList.SelectedIndex = carsList.Items.Count - 1;
                changesSaved = false;
                EnableSave(true);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!changesSaved)
            {
                foreach (Transport car in carsList.Items.Cast<Transport>())
                {
                    if (CityTransport.Cars.Contains(new KeyValuePair<ID, Transport>(car.ID, car)))
                    {
                        CityTransport.Cars[car.ID] = car;
                    }
                    else
                    {
                        CityTransport.Cars.Add(car.ID, car);
                    }
                }

                List<ID> IDList = new List<ID>();
                foreach (ID id in CityTransport.Cars.Keys)
                {
                    if (!carsList.Items.Contains(CityTransport.Cars[id]))
                    {
                        IDList.Add(id);
                    }
                }

                foreach (ID id in IDList)
                {
                    CityTransport.Cars.Remove(id);
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
    }
}
