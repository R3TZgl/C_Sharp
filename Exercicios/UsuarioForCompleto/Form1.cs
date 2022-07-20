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
            listBox2.Items.Clear();
            try
            {
                int inicio = Convert.ToInt16(txtInicio.Text);
                int fim = Convert.ToInt16(txtFim.Text);
                int passo = Convert.ToInt16(txtPasso.Text);
                int valor = 0;
                int tipo = 0;
                int mult = 0;

                if (fim >= inicio)
                {
                    for (int i = inicio; i <= fim; i += passo)
                    {
                        string numero = i.ToString();
                        listBox1.Items.Add(numero);

                        if (i % 2 == 0)
                        {
                            tipo += 1;
                        }
                        if (i % 7 == 0 && i != 0)
                        {
                            mult += 1;
                        }
                        if (i < 0)
                        {
                            valor += 1;
                        }
                    }
                }
                else
                {
                    for (int i = inicio; i >= fim; i -= passo)
                    {
                        string numero = i.ToString();
                        listBox1.Items.Add(numero);

                        if (i % 2 == 0)
                        {
                            tipo += 1;
                        }
                        if (i % 7 == 0 && i != 0)
                        {
                            mult += 1;
                        }
                        if (i < 0)
                        {
                            valor += 1;
                        }
                    }
                }
                listBox2.Items.Add(valor + " Negativos");
                listBox2.Items.Add(tipo + " Pares");
                listBox2.Items.Add(mult + " Múltiplos de 7");
            }
            catch
            {
                MessageBox.Show("Erro de Entrada de valores", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}