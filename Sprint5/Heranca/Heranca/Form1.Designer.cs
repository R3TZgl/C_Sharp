namespace Heranca
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
            this.rProf = new System.Windows.Forms.RadioButton();
            this.rAluno = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEscolha = new System.Windows.Forms.TextBox();
            this.lblEscolha = new System.Windows.Forms.Label();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.lblMat = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rProf
            // 
            this.rProf.AutoSize = true;
            this.rProf.Checked = true;
            this.rProf.Location = new System.Drawing.Point(21, 28);
            this.rProf.Name = "rProf";
            this.rProf.Size = new System.Drawing.Size(99, 25);
            this.rProf.TabIndex = 0;
            this.rProf.TabStop = true;
            this.rProf.Text = "Professor";
            this.rProf.UseVisualStyleBackColor = true;
            this.rProf.CheckedChanged += new System.EventHandler(this.rProf_CheckedChanged);
            // 
            // rAluno
            // 
            this.rAluno.AutoSize = true;
            this.rAluno.Location = new System.Drawing.Point(21, 53);
            this.rAluno.Name = "rAluno";
            this.rAluno.Size = new System.Drawing.Size(74, 25);
            this.rAluno.TabIndex = 1;
            this.rAluno.TabStop = true;
            this.rAluno.Text = "Aluno";
            this.rAluno.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rAluno);
            this.groupBox1.Controls.Add(this.rProf);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(38, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 98);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deseja Cadastrar?";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMatricula.Location = new System.Drawing.Point(38, 129);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(87, 21);
            this.lblMatricula.TabIndex = 3;
            this.lblMatricula.Text = "Matrícula:";
            // 
            // txtMat
            // 
            this.txtMat.Location = new System.Drawing.Point(127, 127);
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(154, 23);
            this.txtMat.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(127, 161);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(154, 23);
            this.txtNome.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            // 
            // txtEscolha
            // 
            this.txtEscolha.Location = new System.Drawing.Point(127, 195);
            this.txtEscolha.Name = "txtEscolha";
            this.txtEscolha.Size = new System.Drawing.Size(154, 23);
            this.txtEscolha.TabIndex = 8;
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEscolha.Location = new System.Drawing.Point(38, 197);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(71, 21);
            this.lblEscolha.TabIndex = 7;
            this.lblEscolha.Text = "Salário: ";
            // 
            // btnCadastro
            // 
            this.btnCadastro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastro.Location = new System.Drawing.Point(38, 238);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(120, 49);
            this.btnCadastro.TabIndex = 9;
            this.btnCadastro.Text = "CADASTRAR PROFESSOR";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // lblMat
            // 
            this.lblMat.AutoSize = true;
            this.lblMat.Location = new System.Drawing.Point(331, 135);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(0, 15);
            this.lblMat.TabIndex = 10;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(331, 163);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 15);
            this.lblNome.TabIndex = 11;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(331, 195);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(0, 15);
            this.lblResposta.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 336);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMat);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.txtEscolha);
            this.Controls.Add(this.lblEscolha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMat);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rProf;
        private RadioButton rAluno;
        private GroupBox groupBox1;
        private Label lblMatricula;
        private TextBox txtMat;
        private TextBox txtNome;
        private Label label1;
        private TextBox txtEscolha;
        private Label lblEscolha;
        private Button btnCadastro;
        private Label lblMat;
        private Label lblNome;
        private Label lblResposta;
    }
}