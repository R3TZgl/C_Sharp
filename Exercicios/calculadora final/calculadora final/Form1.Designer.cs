namespace calculadora_final
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_past = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUm = new System.Windows.Forms.TextBox();
            this.btnElevado = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnPorcentagem = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnVezes = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.lblPast = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_past
            // 
            this.lbl_past.AutoSize = true;
            this.lbl_past.BackColor = System.Drawing.Color.Transparent;
            this.lbl_past.Location = new System.Drawing.Point(144, -11);
            this.lbl_past.Name = "lbl_past";
            this.lbl_past.Size = new System.Drawing.Size(0, 15);
            this.lbl_past.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, -114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 37);
            this.label1.TabIndex = 54;
            this.label1.Text = "Mini Calculadora";
            // 
            // txtUm
            // 
            this.txtUm.BackColor = System.Drawing.Color.Azure;
            this.txtUm.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUm.Location = new System.Drawing.Point(111, 32);
            this.txtUm.Name = "txtUm";
            this.txtUm.ReadOnly = true;
            this.txtUm.Size = new System.Drawing.Size(234, 114);
            this.txtUm.TabIndex = 53;
            this.txtUm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUm.TextChanged += new System.EventHandler(this.txtUm_TextChanged);
            // 
            // btnElevado
            // 
            this.btnElevado.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnElevado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnElevado.Location = new System.Drawing.Point(171, 209);
            this.btnElevado.Name = "btnElevado";
            this.btnElevado.Size = new System.Drawing.Size(54, 51);
            this.btnElevado.TabIndex = 52;
            this.btnElevado.Text = "x²";
            this.btnElevado.UseVisualStyleBackColor = false;
            this.btnElevado.Click += new System.EventHandler(this.btnElevado_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDiv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDiv.Location = new System.Drawing.Point(111, 210);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(54, 51);
            this.btnDiv.TabIndex = 51;
            this.btnDiv.Text = "1/x";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnPorcentagem
            // 
            this.btnPorcentagem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPorcentagem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPorcentagem.Location = new System.Drawing.Point(111, 152);
            this.btnPorcentagem.Name = "btnPorcentagem";
            this.btnPorcentagem.Size = new System.Drawing.Size(54, 51);
            this.btnPorcentagem.TabIndex = 50;
            this.btnPorcentagem.Text = "%";
            this.btnPorcentagem.UseVisualStyleBackColor = false;
            this.btnPorcentagem.Click += new System.EventHandler(this.btnPorcentagem_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCE.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCE.Location = new System.Drawing.Point(171, 152);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(54, 51);
            this.btnCE.TabIndex = 49;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnC.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnC.Location = new System.Drawing.Point(231, 152);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(54, 51);
            this.btnC.TabIndex = 48;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRaiz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRaiz.Location = new System.Drawing.Point(231, 209);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(54, 51);
            this.btnRaiz.TabIndex = 47;
            this.btnRaiz.Text = "²√x";
            this.btnRaiz.UseVisualStyleBackColor = false;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnApagar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnApagar.Location = new System.Drawing.Point(291, 152);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(54, 51);
            this.btnApagar.TabIndex = 46;
            this.btnApagar.Text = "←";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDivisao.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivisao.Location = new System.Drawing.Point(291, 209);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(54, 51);
            this.btnDivisao.TabIndex = 45;
            this.btnDivisao.Text = "÷";
            this.btnDivisao.UseVisualStyleBackColor = false;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVirgula.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVirgula.Location = new System.Drawing.Point(111, 437);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(54, 51);
            this.btnVirgula.TabIndex = 44;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = false;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn0.Location = new System.Drawing.Point(171, 437);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(54, 51);
            this.btn0.TabIndex = 43;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(231, 380);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(54, 51);
            this.btn9.TabIndex = 42;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(171, 380);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(54, 51);
            this.btn8.TabIndex = 41;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(111, 380);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(54, 51);
            this.btn7.TabIndex = 40;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(231, 323);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(54, 51);
            this.btn6.TabIndex = 39;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(171, 323);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(54, 51);
            this.btn5.TabIndex = 38;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(111, 323);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(54, 51);
            this.btn4.TabIndex = 37;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(111, 266);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(54, 51);
            this.btn1.TabIndex = 36;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(171, 266);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(54, 51);
            this.btn2.TabIndex = 35;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(231, 266);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(54, 51);
            this.btn3.TabIndex = 34;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnVezes
            // 
            this.btnVezes.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnVezes.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVezes.Location = new System.Drawing.Point(291, 266);
            this.btnVezes.Name = "btnVezes";
            this.btnVezes.Size = new System.Drawing.Size(54, 51);
            this.btnVezes.TabIndex = 33;
            this.btnVezes.Text = "x";
            this.btnVezes.UseVisualStyleBackColor = false;
            this.btnVezes.Click += new System.EventHandler(this.btnVezes_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMenos.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenos.Location = new System.Drawing.Point(291, 323);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(54, 51);
            this.btnMenos.TabIndex = 32;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = false;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMais
            // 
            this.btnMais.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMais.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMais.Location = new System.Drawing.Point(291, 380);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(54, 51);
            this.btnMais.TabIndex = 31;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = false;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnIgual.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIgual.Location = new System.Drawing.Point(231, 437);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(114, 51);
            this.btnIgual.TabIndex = 30;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // lblPast
            // 
            this.lblPast.AutoSize = true;
            this.lblPast.BackColor = System.Drawing.Color.Azure;
            this.lblPast.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPast.Location = new System.Drawing.Point(112, 33);
            this.lblPast.Name = "lblPast";
            this.lblPast.Size = new System.Drawing.Size(0, 21);
            this.lblPast.TabIndex = 56;
            this.lblPast.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 527);
            this.Controls.Add(this.lblPast);
            this.Controls.Add(this.lbl_past);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUm);
            this.Controls.Add(this.btnElevado);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnPorcentagem);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnVezes);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.btnIgual);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_past;
        private Label label1;
        private TextBox txtUm;
        private Button btnElevado;
        private Button btnDiv;
        private Button btnPorcentagem;
        private Button btnCE;
        private Button btnC;
        private Button btnRaiz;
        private Button btnApagar;
        private Button btnDivisao;
        private Button btnVirgula;
        private Button btn0;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnVezes;
        private Button btnMenos;
        private Button btnMais;
        private Button btnIgual;
        private Label lblPast;
    }
}