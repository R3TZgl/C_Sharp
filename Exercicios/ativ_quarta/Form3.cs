using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ativ_quarta
{
    public partial class Form3 : Form
    {
        bool btnK = false;
        bool btnR = false;
        bool btnKg = false;

        bool inverter = false;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCK_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            float valor = float.Parse(txtInput.Text);

            if (btnK)
            {
                double final = valor - 273.15;

                txtOutput.Text = final.ToString() + " °C";
            }
            else
            {
                double final = 273.15 + valor;

                txtOutput.Text = final.ToString() + " K";
            }
            

        }

        private void btnRD_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            float valor = float.Parse(txtInput.Text);

            if (btnR)
            {
                double final = valor * 5.47;

                txtOutput.Text = "R$" + final.ToString();
            }
            else
            {
                double final = valor / 5.47;

                txtOutput.Text = "$" + final.ToString();
            }
            

        }

        private void btnKB_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            float valor = float.Parse(txtInput.Text);

            if (btnKg)
            {
                double final = valor / 2.20462;

                txtOutput.Text = final.ToString() + " Kg";
            }
            else
            {
                double final = valor * 2.20462;

                txtOutput.Text = final.ToString() + " lb";
            }
            
        }

        private void btnInverter_Click(object sender, EventArgs e)
        {
            inverter = !inverter;
            if (inverter)
            {
                btnCK.Text = "KELVIN PARA CELSIUS";
                btnRD.Text = "DOLAR PARA REAIS";
                btnKB.Text = "LB PARA KG";

                btnK = true;
                btnR = true;
                btnKg = true;
            }
            else
            {
                btnCK.Text = "CELSIUS PARA KELVIN";
                btnRD.Text = "REAIS PARA DOLAR";
                btnKB.Text = "KG PARA LB";

                btnK = false;
                btnR = false;
                btnKg = false;
            }
            

        }
    }
}
