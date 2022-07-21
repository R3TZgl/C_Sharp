namespace ativ_quarta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFat_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt16(txtNumero.Text);
                int total = 0;

                for (int i = num; i > 0; i--)
                {
                    if (i == num)
                    {
                        listBox1.Items.Add(i.ToString());
                        total = num;
                    }
                    else
                    {
                        total = total * i;
                        listBox1.Items.Add(total.ToString());
                    }
                }
            }
            catch
            {

            }
        }
    }
}