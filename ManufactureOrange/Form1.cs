using ManufactureOrangeEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManufactureOrange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < Factory.BuildMaterials.Count; i++)
            {
                comboBoxInput1.Items.Add(Factory.BuildMaterials[i].BuildMaterialName);
            }

        }

        private void comboBoxInput1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void submitButton1_Click(object sender, EventArgs e)
        {
            if(comboBoxInput1.Text != "")
            {
                for (int i = 0; i < Factory.BuildMaterials.Count; i++)
                {
                    if (Factory.BuildMaterials[i].BuildMaterialName == comboBoxInput1.Text)
                    {
                        label1.Text = Factory.BuildMaterials[i].BuildMaterialName;
                        label2.Text = Factory.BuildMaterials[i].BuildMaterialTemperature.TemperatureKelvinMeltPoint.ToString();
                        label3.Text = Factory.BuildMaterials[i].BuildMaterialId.ToString();
                        break;
                    };
                }
            }
        }
    }
}
