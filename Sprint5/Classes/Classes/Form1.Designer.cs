namespace Classes
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumCartao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.clientGroup = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.clientGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(196, 50);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(230, 23);
            this.txtNome.TabIndex = 1;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(196, 88);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(230, 23);
            this.txtEndereco.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Endereço:";
            // 
            // txtContato
            // 
            this.txtContato.Location = new System.Drawing.Point(196, 127);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(230, 23);
            this.txtContato.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contato:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data De Nascimento:";
            // 
            // txtCredito
            // 
            this.txtCredito.Location = new System.Drawing.Point(196, 210);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(230, 23);
            this.txtCredito.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Limite de crédito:";
            // 
            // txtNumCartao
            // 
            this.txtNumCartao.Location = new System.Drawing.Point(196, 256);
            this.txtNumCartao.Name = "txtNumCartao";
            this.txtNumCartao.Size = new System.Drawing.Size(230, 23);
            this.txtNumCartao.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nº do cartão";
            // 
            // clientGroup
            // 
            this.clientGroup.Controls.Add(this.dateTimePicker1);
            this.clientGroup.Controls.Add(this.txtNumCartao);
            this.clientGroup.Controls.Add(this.label6);
            this.clientGroup.Controls.Add(this.txtCredito);
            this.clientGroup.Controls.Add(this.label5);
            this.clientGroup.Controls.Add(this.label4);
            this.clientGroup.Controls.Add(this.txtContato);
            this.clientGroup.Controls.Add(this.label3);
            this.clientGroup.Controls.Add(this.txtEndereco);
            this.clientGroup.Controls.Add(this.label2);
            this.clientGroup.Controls.Add(this.txtNome);
            this.clientGroup.Controls.Add(this.label1);
            this.clientGroup.Location = new System.Drawing.Point(77, 40);
            this.clientGroup.Name = "clientGroup";
            this.clientGroup.Size = new System.Drawing.Size(500, 322);
            this.clientGroup.TabIndex = 12;
            this.clientGroup.TabStop = false;
            this.clientGroup.Text = "Client";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(196, 166);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(230, 23);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(273, 380);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(101, 40);
            this.btnCadastro.TabIndex = 13;
            this.btnCadastro.Text = "CADASTRAR";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(402, 380);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(101, 40);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(632, 65);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 15);
            this.lblNome.TabIndex = 15;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(632, 89);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(0, 15);
            this.lblEndereco.TabIndex = 16;
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Location = new System.Drawing.Point(632, 114);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(0, 15);
            this.lblContato.TabIndex = 17;
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(632, 141);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(0, 15);
            this.lblLimite.TabIndex = 18;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(632, 168);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(0, 15);
            this.lblNumero.TabIndex = 19;
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(632, 196);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(0, 15);
            this.lblDataNasc.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblLimite);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.clientGroup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.clientGroup.ResumeLayout(false);
            this.clientGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private TextBox txtEndereco;
        private Label label2;
        private TextBox txtContato;
        private Label label3;
        private Label label4;
        private TextBox txtCredito;
        private Label label5;
        private TextBox txtNumCartao;
        private Label label6;
        private GroupBox clientGroup;
        private DateTimePicker dateTimePicker1;
        private Button btnCadastro;
        private Button btnSair;
        private Label lblNome;
        private Label lblEndereco;
        private Label lblContato;
        private Label lblLimite;
        private Label lblNumero;
        private Label lblDataNasc;
    }
}