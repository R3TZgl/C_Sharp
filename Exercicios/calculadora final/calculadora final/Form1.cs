﻿namespace calculadora_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal num_inicial;
        decimal num_final;
        string funcao;
        string past;
        bool virgula = false;

        void digitar(string num)
        {
            if (num == "," && virgula == false)
            {
                txtUm.Text += num;
                virgula = true;
            }
            else if(num != ",")
            {
                txtUm.Text += num;
            }
            txtUm.BackColor = Color.Azure;
        }
        void acao(string botao, string pos = "normal")
        {
            funcao = botao;

            if (pos == "sec")
            {
                if (botao == "²")
                {

                    if (txtUm.Text == "")
                    {
                        if (past == null)
                        {
                            return;
                        }
                        lblPast.Text = past + botao + " ";
                    }
                    else
                    {
                        num_final = Convert.ToDecimal(txtUm.Text);
                        lblPast.Text = txtUm.Text + botao + " ";
                        past = txtUm.Text;
                        txtUm.Text = "";
                        virgula = false;
                    }
                }
                else
                {
                    txtUm.Text = botao;
                }
            }
            else
            {
                if (txtUm.Text == "")
                {
                    if (past == null)
                    {
                        return;
                    }
                    lblPast.Text = past + " " + botao + " ";
                }
                else
                {
                    num_inicial = Convert.ToDecimal(txtUm.Text);
                    lblPast.Text = txtUm.Text + " " + botao + " ";
                    past = txtUm.Text;
                    txtUm.Text = "";
                    virgula = false;
                }
            }
            
            txtUm.BackColor = Color.Azure;
        }

        private void txtUm_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtUm.Text = "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            digitar("0");
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

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            digitar(",");
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if(txtUm.Text != "")
            {
                txtUm.Text = txtUm.Text.Remove(txtUm.Text.Length - 1);
                if (txtUm.Text.Contains(","))
                {
                    virgula = true;
                }
                else
                {
                    virgula = false;
                }
            }
            txtUm.BackColor = Color.Azure;
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            acao("÷");
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            acao("x");
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            acao("-");
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            acao("+");
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            acao("%");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtUm.Text = "";
            lblPast.Text = "";
            past = null;
            num_final = 0;
            num_inicial = 0;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if(funcao == "²")
            {
                lblPast.Text = txtUm.Text;
                txtUm.Text = Convert.ToString(num_final * num_final);
            }else if(funcao == "√")
            {
                lblPast.Text = txtUm.Text;
                txtUm.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(num_final)));
            }else if(funcao == "1 ÷ ")
            {
                lblPast.Text = txtUm.Text;
                txtUm.Text = Convert.ToString(1 / num_final);
            }else if(txtUm.Text == "")
            {
                txtUm.BackColor = Color.LightCoral;
            }


            if(txtUm.Text != "")
            {
                num_final = Convert.ToDecimal(txtUm.Text);
                lblPast.Text += txtUm.Text;
                if(funcao == "+")
                {
                    num_inicial = num_inicial + num_final;
                    txtUm.Text = Convert.ToString(num_inicial);
                }else if(funcao == "-")
                {
                    num_inicial = num_inicial - num_final;
                    txtUm.Text = Convert.ToString(num_inicial);
                }else if (funcao == "x")
                {
                    num_inicial = num_inicial * num_final;
                    txtUm.Text = Convert.ToString(num_inicial);
                }else if (funcao == "÷")
                {
                    num_inicial = num_inicial / num_final;
                    txtUm.Text = Convert.ToString(num_inicial);
                }
            }
        }

        private void btnElevado_Click(object sender, EventArgs e)
        {
            acao("²", "sec");
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            acao("√", "sec");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            acao("1 ÷ ", "sec");
        }
    }
}