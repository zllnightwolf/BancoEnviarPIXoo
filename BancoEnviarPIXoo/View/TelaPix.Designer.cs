namespace BancoEnviarPIXoo.View
{
    partial class TelaPix
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_saldoOrigin = new System.Windows.Forms.Label();
            this.lbl_cpfOrigin = new System.Windows.Forms.Label();
            this.lbl_nomeOrigin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_nomeDestino = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.lbl_cpfDestino = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_transferir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(154, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "PIX";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_saldoOrigin);
            this.groupBox1.Controls.Add(this.lbl_cpfOrigin);
            this.groupBox1.Controls.Add(this.lbl_nomeOrigin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(27, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 127);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seus Dados:";
            // 
            // lbl_saldoOrigin
            // 
            this.lbl_saldoOrigin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_saldoOrigin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_saldoOrigin.Location = new System.Drawing.Point(58, 89);
            this.lbl_saldoOrigin.Name = "lbl_saldoOrigin";
            this.lbl_saldoOrigin.Size = new System.Drawing.Size(215, 22);
            this.lbl_saldoOrigin.TabIndex = 6;
            this.lbl_saldoOrigin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cpfOrigin
            // 
            this.lbl_cpfOrigin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_cpfOrigin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cpfOrigin.Location = new System.Drawing.Point(58, 53);
            this.lbl_cpfOrigin.Name = "lbl_cpfOrigin";
            this.lbl_cpfOrigin.Size = new System.Drawing.Size(215, 22);
            this.lbl_cpfOrigin.TabIndex = 6;
            this.lbl_cpfOrigin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nomeOrigin
            // 
            this.lbl_nomeOrigin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_nomeOrigin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nomeOrigin.Location = new System.Drawing.Point(58, 23);
            this.lbl_nomeOrigin.Name = "lbl_nomeOrigin";
            this.lbl_nomeOrigin.Size = new System.Drawing.Size(215, 20);
            this.lbl_nomeOrigin.TabIndex = 6;
            this.lbl_nomeOrigin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Saldo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_nomeDestino);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_valor);
            this.groupBox2.Controls.Add(this.lbl_cpfDestino);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(27, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 140);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destino";
            // 
            // lbl_nomeDestino
            // 
            this.lbl_nomeDestino.BackColor = System.Drawing.Color.Brown;
            this.lbl_nomeDestino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nomeDestino.Location = new System.Drawing.Point(58, 23);
            this.lbl_nomeDestino.Name = "lbl_nomeDestino";
            this.lbl_nomeDestino.Size = new System.Drawing.Size(215, 24);
            this.lbl_nomeDestino.TabIndex = 6;
            this.lbl_nomeDestino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "Nome:";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(58, 101);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(122, 23);
            this.txt_valor.TabIndex = 6;
            // 
            // lbl_cpfDestino
            // 
            this.lbl_cpfDestino.BackColor = System.Drawing.Color.Brown;
            this.lbl_cpfDestino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cpfDestino.Location = new System.Drawing.Point(58, 63);
            this.lbl_cpfDestino.Name = "lbl_cpfDestino";
            this.lbl_cpfDestino.Size = new System.Drawing.Size(215, 23);
            this.lbl_cpfDestino.TabIndex = 6;
            this.lbl_cpfDestino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Valor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "CPF:";
            // 
            // btn_transferir
            // 
            this.btn_transferir.Location = new System.Drawing.Point(68, 393);
            this.btn_transferir.Name = "btn_transferir";
            this.btn_transferir.Size = new System.Drawing.Size(244, 36);
            this.btn_transferir.TabIndex = 5;
            this.btn_transferir.Text = "Transferir";
            this.btn_transferir.UseVisualStyleBackColor = true;
            this.btn_transferir.Click += new System.EventHandler(this.btn_transferir_Click);
            // 
            // TelaPix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 441);
            this.Controls.Add(this.btn_transferir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TelaPix";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPix";
            this.Load += new System.EventHandler(this.TelaPix_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Label lbl_saldoOrigin;
        private Label lbl_cpfOrigin;
        private Label lbl_nomeOrigin;
        private Label label4;
        private GroupBox groupBox2;
        private Label lbl_nomeDestino;
        private Label label11;
        private TextBox txt_valor;
        private Label lbl_cpfDestino;
        private Label label7;
        private Label label6;
        private Button btn_transferir;
    }
}