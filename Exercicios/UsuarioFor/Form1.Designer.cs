namespace UsuarioFor
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.txtFim = new System.Windows.Forms.TextBox();
            this.lblFim = new System.Windows.Forms.Label();
            this.txtPasso = new System.Windows.Forms.TextBox();
            this.lblPasso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIniciar.Location = new System.Drawing.Point(259, 194);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(86, 42);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(423, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 193);
            this.listBox1.TabIndex = 1;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInicio.Location = new System.Drawing.Point(181, 52);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(58, 25);
            this.lblInicio.TabIndex = 2;
            this.lblInicio.Text = "Início";
            // 
            // txtInicio
            // 
            this.txtInicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInicio.Location = new System.Drawing.Point(245, 52);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(100, 29);
            this.txtInicio.TabIndex = 3;
            // 
            // txtFim
            // 
            this.txtFim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFim.Location = new System.Drawing.Point(245, 99);
            this.txtFim.Name = "txtFim";
            this.txtFim.Size = new System.Drawing.Size(100, 29);
            this.txtFim.TabIndex = 5;
            // 
            // lblFim
            // 
            this.lblFim.AutoSize = true;
            this.lblFim.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFim.Location = new System.Drawing.Point(181, 99);
            this.lblFim.Name = "lblFim";
            this.lblFim.Size = new System.Drawing.Size(42, 25);
            this.lblFim.TabIndex = 4;
            this.lblFim.Text = "Fim";
            // 
            // txtPasso
            // 
            this.txtPasso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPasso.Location = new System.Drawing.Point(245, 143);
            this.txtPasso.Name = "txtPasso";
            this.txtPasso.Size = new System.Drawing.Size(100, 29);
            this.txtPasso.TabIndex = 7;
            // 
            // lblPasso
            // 
            this.lblPasso.AutoSize = true;
            this.lblPasso.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPasso.Location = new System.Drawing.Point(181, 143);
            this.lblPasso.Name = "lblPasso";
            this.lblPasso.Size = new System.Drawing.Size(59, 25);
            this.lblPasso.TabIndex = 6;
            this.lblPasso.Text = "Passo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPasso);
            this.Controls.Add(this.lblPasso);
            this.Controls.Add(this.txtFim);
            this.Controls.Add(this.lblFim);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnIniciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnIniciar;
        private ListBox listBox1;
        private Label lblInicio;
        private TextBox txtInicio;
        private TextBox txtFim;
        private Label lblFim;
        private TextBox txtPasso;
        private Label lblPasso;
    }
}