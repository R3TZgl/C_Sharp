namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal num1;
        decimal num2;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUm_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtDois_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtDois_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUm_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
          

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            

        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            

        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString("dd'-'MM'-'yyyy");
        }

        private void btnIgual_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtUm_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtDois_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
        void digitar(string caractere)
        {
            
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            digitar("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            digitar("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            digitar("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            digitar("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            digitar("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            digitar("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            digitar("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            digitar("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            digitar("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            digitar("0");
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            digitar(",");
        }

        private void btnElevado_Click(object sender, EventArgs e)
        {
            //Nada ainda
        }
        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            
        }

    }

}