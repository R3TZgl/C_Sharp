namespace UsuarioFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                int inicio = Convert.ToInt16(txtInicio.Text);
                int fim = Convert.ToInt16(txtFim.Text);
                int passo = Convert.ToInt16(txtPasso.Text);

                if (fim >= inicio)
                {
                    for (int i = inicio; i <= fim; i += passo)
                    {
                        string numero = i.ToString();
                        listBox1.Items.Add(numero);
                    }
                }
                else
                {
                    for (int i = inicio; i >= fim; i -= passo)
                    {
                        string numero = i.ToString();
                        listBox1.Items.Add(numero);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro de Entrada de valores", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}