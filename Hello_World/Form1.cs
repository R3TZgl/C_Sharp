namespace Hello_World
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClique_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");

            Close(); //Fechar uma janela
            Application.Exit(); //Fechar o programa

        }

    }
}