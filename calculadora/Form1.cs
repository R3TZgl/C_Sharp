namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool status = true;

        bool caixa1 = true;
        bool caixa2 = false;

        float resultado;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDois_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDois_TextChanged(object sender, EventArgs e)
        {
            if ((txtUm.Text != String.Empty) && (txtDois.Text != String.Empty))
            {
                btnIgual.Enabled = true;
                btnDivisao.Enabled = true;
                btnApagar.Enabled = true;
                btnC.Enabled = true;
                btnMenos.Enabled = true;
                btnVirgula.Enabled = true;
                btnMais.Enabled = true;
                btnVezes.Enabled = true;
                btnPorcentagem.Enabled = true;
                //btnDiv.Enabled = true;
                //btnCE.Enabled = true;
                //btnElevado.Enabled = true;
                //btnRaiz.Enabled = true;
            }
            else
            {
                btnDivisao.Enabled = false;
                btnDiv.Enabled = false;
                btnC.Enabled = false;
                btnCE.Enabled = false;
                btnElevado.Enabled = false;
                btnMenos.Enabled = false;
                btnRaiz.Enabled = false;
                btnVirgula.Enabled = false;
                btnMais.Enabled = false;
                btnVezes.Enabled = false;
                btnPorcentagem.Enabled = false;
            }
        }

        private void txtUm_TextChanged(object sender, EventArgs e)
        {
            if ((txtUm.Text != String.Empty) && (txtDois.Text != String.Empty))
            {
                btnIgual.Enabled = true;
                btnDivisao.Enabled = true;
                btnApagar.Enabled = true;
                btnC.Enabled = true;
                btnMenos.Enabled = true;
                btnVirgula.Enabled = true;
                btnMais.Enabled = true;
                btnVezes.Enabled = true;
                btnPorcentagem.Enabled = true;
                //btnDiv.Enabled = true;
                //btnCE.Enabled = true;
                //btnElevado.Enabled = true;
                //btnRaiz.Enabled = true;
            }
            else
            {
                btnDivisao.Enabled = false;
                btnDiv.Enabled = false;
                btnC.Enabled = false;
                btnCE.Enabled = false;
                btnElevado.Enabled = false;
                btnMenos.Enabled = false;
                btnRaiz.Enabled = false;
                btnVirgula.Enabled = false;
                btnMais.Enabled = false;
                btnVezes.Enabled = false;
                btnPorcentagem.Enabled = false;
            }
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            resultado = float.Parse(txtUm.Text) + float.Parse(txtDois.Text);

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            resultado = float.Parse(txtUm.Text) - float.Parse(txtDois.Text);

        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            resultado = float.Parse(txtUm.Text) * float.Parse(txtDois.Text);

        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            resultado = float.Parse(txtUm.Text) / float.Parse(txtDois.Text);
            
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (caixa1)
            {
                var numero = txtUm.Text;
                txtUm.Text = numero.Remove(numero.Length - 1);
            }else if (caixa2)
            {
                var numero = txtDois.Text;
                txtDois.Text = numero.Remove(numero.Length - 1);
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDois.Text = "";
            txtUm.Text = "";
            textBox1.Text = "";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString("dd'-'MM'-'yyyy");
        }

        private void btnIgual_MouseClick(object sender, MouseEventArgs e)
        {
            status = !status;
            if (status == false)
            {
                textBox1.BackColor = Color.GreenYellow;
            }
            if (status)
            {
                textBox1.BackColor = Color.Azure;
            }

            textBox1.Text = resultado.ToString();

        }

        private void txtUm_MouseClick(object sender, MouseEventArgs e)
        {
            caixa1 = true;
            caixa2 = false;
        }

        private void txtDois_MouseClick(object sender, MouseEventArgs e)
        {
            caixa2 = true;
            caixa1 = false;
        }
        void digitar(string caractere)
        {
            if (caixa1)
            {
                txtUm.Text = txtUm.Text + caractere;
            }
            else if (caixa2)
            {
                txtDois.Text = txtDois.Text + caractere;
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            digitar("0");
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
            resultado = float.Parse(txtDois.Text) * float.Parse(txtUm.Text) / 100;
        }

    }

}