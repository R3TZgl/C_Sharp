using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Button Form2)
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            Form1 um = new Form1();
            um.ShowDialog();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 dois = new Form2();
            dois.ShowDialog();
        }
    }
}
