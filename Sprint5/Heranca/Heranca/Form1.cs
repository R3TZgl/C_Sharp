namespace Heranca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Professor nova_pessoa = new();
        bool escolha = true;
        private void rProf_CheckedChanged(object sender, EventArgs e)
        {
            if (rProf.Checked)
            {
                lblEscolha.Text = "Salário:";
                btnCadastro.Text = "CADASTRAR PROFESSOR";
                escolha = true;
            }
            else
            {
                lblEscolha.Text = "Média:";
                btnCadastro.Text = "CADASTRAR ALUNO";
                escolha = false;
            }
        }
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                if (escolha)
                {
                    Professor nova_pessoa = new();
                    nova_pessoa.Salario = Convert.ToDouble(txtEscolha.Text);
                    lblResposta.Text = "Salário: R$" + Convert.ToString(nova_pessoa.Salario);
                }
                else
                {
                    Aluno nova_pessoa = new();
                    nova_pessoa.Media = Convert.ToDouble(txtEscolha.Text);
                    lblResposta.Text = "Média: " + Convert.ToString(nova_pessoa.Media);
                }
                nova_pessoa.Matricula = Convert.ToInt16(txtMat.Text);
                nova_pessoa.Nome = txtNome.Text;

                lblMat.Text = "Matrícula: " + Convert.ToString(nova_pessoa.Matricula);
                lblNome.Text = "Nome: " + nova_pessoa.Nome;
            }
            catch
            {
                MessageBox.Show("Erro ao cadastrar informações", "Cadastro");
            }
        }
    }
}