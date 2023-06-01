namespace BancoEnviarPIXoo.View
{
    partial class TelaBanco1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_nomeB1 = new System.Windows.Forms.Label();
            this.lbl_cpfB1 = new System.Windows.Forms.Label();
            this.lbl_saldoB1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo:";
            // 
            // lbl_nomeB1
            // 
            this.lbl_nomeB1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_nomeB1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nomeB1.Location = new System.Drawing.Point(97, 65);
            this.lbl_nomeB1.Name = "lbl_nomeB1";
            this.lbl_nomeB1.Size = new System.Drawing.Size(266, 21);
            this.lbl_nomeB1.TabIndex = 3;
            this.lbl_nomeB1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cpfB1
            // 
            this.lbl_cpfB1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_cpfB1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cpfB1.Location = new System.Drawing.Point(97, 109);
            this.lbl_cpfB1.Name = "lbl_cpfB1";
            this.lbl_cpfB1.Size = new System.Drawing.Size(266, 21);
            this.lbl_cpfB1.TabIndex = 4;
            this.lbl_cpfB1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_saldoB1
            // 
            this.lbl_saldoB1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_saldoB1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_saldoB1.Location = new System.Drawing.Point(93, 152);
            this.lbl_saldoB1.Name = "lbl_saldoB1";
            this.lbl_saldoB1.Size = new System.Drawing.Size(270, 28);
            this.lbl_saldoB1.TabIndex = 5;
            this.lbl_saldoB1.Text = "Para ver o saldo - Clique no Botão";
            this.lbl_saldoB1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_saldoB1.Click += new System.EventHandler(this.lbl_saldoB1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(30, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 96);
            this.button1.TabIndex = 6;
            this.button1.Text = "Fazer Pix";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(219, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 96);
            this.button2.TabIndex = 7;
            this.button2.Text = "Ver Saldo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TelaBanco1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 393);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_saldoB1);
            this.Controls.Add(this.lbl_cpfB1);
            this.Controls.Add(this.lbl_nomeB1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TelaBanco1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco1";
            this.Load += new System.EventHandler(this.TelaBanco1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbl_nomeB1;
        private Label lbl_cpfB1;
        private Label lbl_saldoB1;
        private Button button1;
        private Button button2;
    }
}