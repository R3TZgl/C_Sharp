namespace Classe_aluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Aluno novo_aluno = new Aluno();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            try
            {
                novo_aluno.setNome(txtNome.Text);
                novo_aluno.setEndereco(txtEndereco.Text);
                novo_aluno.setNota1(Convert.ToDouble(txtN1.Text));
                novo_aluno.setNota2(Convert.ToDouble(txtN2.Text));
                novo_aluno.setNota3(Convert.ToDouble(txtN3.Text));
                novo_aluno.setDataNasc(dateTimePicker1.Value);

                MessageBox.Show("Aluno cadastrado com sucesso.", "Cadastro");

                lblInfo.Text = "Nome:  " + novo_aluno.getNome();
                lblInfo.Text += "\n\n Endereço:  " + novo_aluno.getEndereco();
            }
            catch
            {
                MessageBox.Show("Erro ao inserir os dados.", "Erro");
            }
            
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            try
            {
                lblInfo.Text = "Nome:  " + novo_aluno.getNome();
                lblInfo.Text += "\n\n Endereço:  " + novo_aluno.getEndereco();
                lblInfo.Text += "\n\n Média:  " + Convert.ToString(novo_aluno.calcular());
                lblInfo.Text += "\n\n Situação:  " + novo_aluno.getSituacao();
                lblSituacao.ForeColor = novo_aluno.getCor();
                lblSituacao.Text = novo_aluno.getSituacao();
            }
            catch
            {
                MessageBox.Show("Erro ao inserir os dados.", "Erro");
            }
        }
    }
}