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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                int inicio = Convert.ToInt16(txtInicio.Text);
                int fim = Convert.ToInt16(txtFim.Text);

                if (fim >= inicio)
                {
                    for (int i = inicio; i <= fim; i ++)
                    {
                        string numero = i.ToString();
                        listBox1.Items.Add(numero);
                    }
                }
                else
                {
                    for (int i = inicio; i >= fim; i --)
                    {
                        string numero = i.ToString();
                        listBox1.Items.Add(numero);
                    }
                }
            }
            catch
            {

            }
        }
    }
}
