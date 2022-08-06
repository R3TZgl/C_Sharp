namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Cliente novo_cliente = new Cliente();

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
            novo_cliente.setNome(txtNome.Text);
            novo_cliente.setContato(txtContato.Text);
            novo_cliente.setEndereco(txtEndereco.Text);
            novo_cliente.setDataNasc(dateTimePicker1.Value);
            novo_cliente.setNumeroCartao(Convert.ToInt16(txtNumCartao.Text));
            novo_cliente.setLimiteCartao(double.Parse(txtCredito.Text));

            MessageBox.Show("Cliente cadastrado com sucesso.");

            novo_cliente.verificarLimite();

            MessageBox.Show("Sua situação atual é " + novo_cliente.getStatus(), "Aviso");

                lblNome.Text = novo_cliente.getNome();
                lblContato.Text = novo_cliente.getContato();
                lblEndereco.Text = novo_cliente.getEndereco();
                lblLimite.Text = novo_cliente.getLimiteCartao().ToString();
                lblNumero.Text = novo_cliente.getNumeroCartao().ToString();
                lblDataNasc.Text = novo_cliente.getDataNasc().ToString();
            }
            catch{
                MessageBox.Show("Erro de cadastro", "Tente Novamente");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}