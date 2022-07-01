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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            Form2 dois = new Form2();
            dois.ShowDialog();
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            Form3 tres = new Form3();
            tres.ShowDialog();
        }
    }
}