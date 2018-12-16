using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportLab
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void EditCars_Click(object sender, EventArgs e)
        {
            CityTransport.Context.MainForm = new CarsManagement();
            Close();
            CityTransport.Context.MainForm.Show();
        }

        private void EditRoutes_Click(object sender, EventArgs e)
        {
            CityTransport.Context.MainForm = new RoutesManagement();
            Close();
            CityTransport.Context.MainForm.Show();
        }

        private void SaveData_Click(object sender, EventArgs e)
        {
            CityTransport.Context.MainForm = new SaveForm();
            Close();
            CityTransport.Context.MainForm.Show();
        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            CityTransport.Context.MainForm = new LoadForm();
            Close();
            CityTransport.Context.MainForm.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
