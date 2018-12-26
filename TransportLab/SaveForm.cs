using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using SerializeLibrary;
using TransportLibrary;

namespace TransportLab
{
    public partial class SaveForm : Form
    {
        public SaveForm()
        {
            InitializeComponent();

            LoadSerializerTypes();
        }

        private void LoadSerializerTypes()
        {
            SerializerTypes.Items.Add(Serializers.Binary);
            SerializerTypes.Items.Add(Serializers.XML);
            SerializerTypes.Items.Add(Serializers.JSON);
            SerializerTypes.SelectedIndex = 0;
        }

        private void InputFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (FileNameIn.Text != String.Empty)
            {
                if (!Directory.Exists(@"..\Saves\"))
                {
                    Directory.CreateDirectory(@"..\Saves\");
                }
                switch (SerializerTypes.SelectedItem)
                {
                    case Serializers.Binary:
                        BinarySerializer binarySerializer = new BinarySerializer();
                        binarySerializer.Save(@"..\Saves\Transport" + FileNameIn.Text.Trim(), ConvertData.DictToList(Transport.Cars));
                        binarySerializer.Save(@"..\Saves\Routes" + FileNameIn.Text.Trim(), ConvertData.DictToList(Route.Routes));
                        break;
                    case Serializers.XML:
                        XMLSerializer xmlSerializer = new XMLSerializer();
                        xmlSerializer.Save(@"..\Saves\Transport" + FileNameIn.Text.Trim(), ConvertData.DictToList(Transport.Cars));
                        xmlSerializer.Save(@"..\Saves\Routes" + FileNameIn.Text.Trim(), ConvertData.DictToList(Route.Routes));
                        break;
                    case Serializers.JSON:
                        JSONSerializer jsonSerializer = new JSONSerializer();
                        jsonSerializer.Save(@"..\Saves\Transport" + FileNameIn.Text.Trim(), ConvertData.DictToList(Transport.Cars));
                        jsonSerializer.Save(@"..\Saves\Routes" + FileNameIn.Text.Trim(), ConvertData.DictToList(Route.Routes));
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
    }
}
