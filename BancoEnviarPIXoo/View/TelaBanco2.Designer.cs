namespace BancoEnviarPIXoo.View
{
    partial class TelaBanco2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_nomeB2 = new System.Windows.Forms.Label();
            this.lbl_cpfB2 = new System.Windows.Forms.Label();
            this.lbl_saldoB2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(29, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 92);
            this.button1.TabIndex = 3;
            this.button1.Text = "Fazer Pix";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(221, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 92);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ver Saldo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_nomeB2
            // 
            this.lbl_nomeB2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_nomeB2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nomeB2.Location = new System.Drawing.Point(92, 42);
            this.lbl_nomeB2.Name = "lbl_nomeB2";
            this.lbl_nomeB2.Size = new System.Drawing.Size(267, 20);
            this.lbl_nomeB2.TabIndex = 5;
            this.lbl_nomeB2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cpfB2
            // 
            this.lbl_cpfB2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_cpfB2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cpfB2.Location = new System.Drawing.Point(92, 88);
            this.lbl_cpfB2.Name = "lbl_cpfB2";
            this.lbl_cpfB2.Size = new System.Drawing.Size(267, 20);
            this.lbl_cpfB2.TabIndex = 6;
            this.lbl_cpfB2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_saldoB2
            // 
            this.lbl_saldoB2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_saldoB2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_saldoB2.Location = new System.Drawing.Point(92, 129);
            this.lbl_saldoB2.Name = "lbl_saldoB2";
            this.lbl_saldoB2.Size = new System.Drawing.Size(267, 21);
            this.lbl_saldoB2.TabIndex = 7;
            this.lbl_saldoB2.Text = "Para ver o saldo - Clique no Botão";
            this.lbl_saldoB2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_saldoB2.Click += new System.EventHandler(this.lbl_saldoB2_Click);
            // 
            // TelaBanco2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 357);
            this.Controls.Add(this.lbl_saldoB2);
            this.Controls.Add(this.lbl_cpfB2);
            this.Controls.Add(this.lbl_nomeB2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TelaBanco2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco 2";
            this.Load += new System.EventHandler(this.TelaBanco2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label lbl_nomeB2;
        private Label lbl_cpfB2;
        private Label lbl_saldoB2;
    }
}