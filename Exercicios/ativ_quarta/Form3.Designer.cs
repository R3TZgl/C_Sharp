namespace ativ_quarta
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCK = new System.Windows.Forms.Button();
            this.btnRD = new System.Windows.Forms.Button();
            this.btnKB = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInverter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(439, 79);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(114, 23);
            this.txtInput.TabIndex = 0;
            // 
            // btnCK
            // 
            this.btnCK.Location = new System.Drawing.Point(190, 79);
            this.btnCK.Name = "btnCK";
            this.btnCK.Size = new System.Drawing.Size(130, 48);
            this.btnCK.TabIndex = 2;
            this.btnCK.Text = "CELSIUS PARA KELVIN";
            this.btnCK.UseVisualStyleBackColor = true;
            this.btnCK.Click += new System.EventHandler(this.btnCK_Click);
            // 
            // btnRD
            // 
            this.btnRD.Location = new System.Drawing.Point(190, 133);
            this.btnRD.Name = "btnRD";
            this.btnRD.Size = new System.Drawing.Size(130, 48);
            this.btnRD.TabIndex = 3;
            this.btnRD.Text = "REAIS PARA DOLAR";
            this.btnRD.UseVisualStyleBackColor = true;
            this.btnRD.Click += new System.EventHandler(this.btnRD_Click);
            // 
            // btnKB
            // 
            this.btnKB.Location = new System.Drawing.Point(190, 187);
            this.btnKB.Name = "btnKB";
            this.btnKB.Size = new System.Drawing.Size(130, 48);
            this.btnKB.TabIndex = 4;
            this.btnKB.Text = "KG PARA LB";
            this.btnKB.UseVisualStyleBackColor = true;
            this.btnKB.Click += new System.EventHandler(this.btnKB_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOutput.Location = new System.Drawing.Point(439, 201);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(114, 32);
            this.txtOutput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(356, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(375, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Saída";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnInverter
            // 
            this.btnInverter.Location = new System.Drawing.Point(12, 12);
            this.btnInverter.Name = "btnInverter";
            this.btnInverter.Size = new System.Drawing.Size(86, 48);
            this.btnInverter.TabIndex = 8;
            this.btnInverter.Text = "INVERTER";
            this.btnInverter.UseVisualStyleBackColor = true;
            this.btnInverter.Click += new System.EventHandler(this.btnInverter_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInverter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnKB);
            this.Controls.Add(this.btnRD);
            this.Controls.Add(this.btnCK);
            this.Controls.Add(this.txtInput);
            this.Name = "Form3";
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtInput;
        private Button btnCK;
        private Button btnRD;
        private Button btnKB;
        private TextBox txtOutput;
        private Label label1;
        private Label label2;
        private Button btnInverter;
    }
}