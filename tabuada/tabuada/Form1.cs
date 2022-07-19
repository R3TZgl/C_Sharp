namespace tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            listBox1.Items.Clear();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            string mult, loop;
            try
            {
                int num = Convert.ToInt16(txtNumero.Text);
                for (int i = 0; i <=10; i++)
                {
                    loop = Convert.ToString(i);
                    mult = Convert.ToString(i * num);
                    listBox1.Items.Add(Convert.ToString(num) + " x " + loop + " = " + mult);
                }
            }
            catch
            {
                MessageBox.Show("Insira um número para calcular", "ERRO", MessageBoxButtons.YesNoCancel);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}