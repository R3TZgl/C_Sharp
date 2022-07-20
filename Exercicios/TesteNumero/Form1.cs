namespace TesteNumero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                int num = Convert.ToInt16(txtNumero.Text);
                string valor, tipo;

                if (num >= 0)
                {
                    valor = "positivo";
                }
                else
                {
                    valor = "negativo";
                }

                if (num % 2 == 0)
                {
                    tipo = "par";
                }
                else
                {
                    tipo = "ínpar";
                }

                listBox1.Items.Add("O número é " + valor);
                listBox1.Items.Add("O número é " + tipo);
            }
            catch
            {
                MessageBox.Show("Erro de Entrada", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}