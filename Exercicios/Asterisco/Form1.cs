namespace Asterisco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApertar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string txt = "";
            for (int i = 0; i < 10; i++)
            {
                txt = txt + "*";
                listBox1.Items.Add(txt);
            }
        }

        private void btnInverter_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string txt = "***********";
            for (int i = 0; i < 10; i++)
            {
                txt = txt.Remove(txt.Length - 1);
                listBox1.Items.Add(txt);
            }
        }

        private void btnCentro_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string txt = "***********";
            string space = "";
            for (int i = 0; i < 10; i++)
            {
                txt = txt.Remove(txt.Length - 1);
                space = space + " ";
                listBox1.Items.Add(space + txt);
            }

            for (int i = 0; i < 10; i++)
            {
                space = space.Remove(space.Length - 1);
                txt = txt + "*";
                listBox1.Items.Add(space + txt);
            }

            
        }
    }
}