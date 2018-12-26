using SerializeLibrary;
using TransportLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TransportLab
{
    public partial class LoadForm : Form
    {
        private string[] files;

        public LoadForm()
        {
            InitializeComponent();

            files = new string[0];

            LoadSerializerTypes();
        }

        private void LoadSerializerTypes()
        {
            SerializerTypes.Items.Add(Serializers.Binary);
            SerializerTypes.Items.Add(Serializers.XML);
            SerializerTypes.Items.Add(Serializers.JSON);
            SerializerTypes.SelectedIndex = 0;
        }

        private void SerializerTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(@"..\Saves\"))
            {
                switch (SerializerTypes.SelectedItem)
                {
                    case Serializers.Binary:
                        files = Directory.GetFiles(@"..\Saves\", "*.bin");
                        break;
                    case Serializers.XML:
                        files = Directory.GetFiles(@"..\Saves\", "*.xml");
                        break;
                    case Serializers.JSON:
                        files = Directory.GetFiles(@"..\Saves\", "*.json");
                        break;
                }

                FilesList.Items.Clear();
                foreach (string file in files)
                {
                    FilesList.Items.Add(file.Split('\\').Last());
                }
            }

            if (FilesList.Items.Count > 0)
            {
                FilesList.SelectedIndex = 0;
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (FilesList.SelectedIndex > -1)
            {
                switch(SerializerTypes.SelectedItem)
                {
                    case Serializers.Binary:
                        if (FilesList.SelectedItem.ToString().Contains("Transport"))
                        {
                            BinarySerializer serializer = new BinarySerializer();
                            Transport.Cars = ConvertData.ListToDict(serializer.Load<Transport>(files[FilesList.SelectedIndex]));
                        }
                        else if (FilesList.SelectedItem.ToString().Contains("Routes"))
                        {
                            BinarySerializer serializer = new BinarySerializer();
                            Route.Routes = ConvertData.ListToDict(serializer.Load<Route>(files[FilesList.SelectedIndex]));
                        }
                        break;
                    case Serializers.XML:
                        if (FilesList.SelectedItem.ToString().Contains("Transport"))
                        {
                            XMLSerializer serializer = new XMLSerializer();
                            Transport.Cars = ConvertData.ListToDict(serializer.Load<Transport>(files[FilesList.SelectedIndex]));
                        }
                        else if (FilesList.SelectedItem.ToString().Contains("Routes"))
                        {
                            XMLSerializer serializer = new XMLSerializer();
                            Route.Routes = ConvertData.ListToDict(serializer.Load<Route>(files[FilesList.SelectedIndex]));
                        }
                        break;
                    case Serializers.JSON:
                        if (FilesList.SelectedItem.ToString().Contains("Transport"))
                        {
                            JSONSerializer serializer = new JSONSerializer();
                            Transport.Cars = ConvertData.ListToDict(serializer.Load<Transport>(files[FilesList.SelectedIndex]));
                        }
                        else if (FilesList.SelectedItem.ToString().Contains("Routes"))
                        {
                            JSONSerializer serializer = new JSONSerializer();
                            Route.Routes = ConvertData.ListToDict(serializer.Load<Route>(files[FilesList.SelectedIndex]));
                        }
                        break;
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            CityTransport.Context.MainForm = new MainMenu();
            Close();
            CityTransport.Context.MainForm.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (FilesList.SelectedIndex > -1)
            {
                File.Delete(files[FilesList.SelectedIndex]);

                SerializerTypes_SelectedIndexChanged(this, new EventArgs());
            }
        }
    }
}
