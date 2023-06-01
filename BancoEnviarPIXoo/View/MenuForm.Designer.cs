namespace BancoEnviarPIXoo.View
{
    partial class MenuForm
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
            this.btn_Banco1 = new System.Windows.Forms.Button();
            this.btn_Banco2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(44, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qual Banco deseja entrar?";
            // 
            // btn_Banco1
            // 
            this.btn_Banco1.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_Banco1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Banco1.Location = new System.Drawing.Point(30, 159);
            this.btn_Banco1.Name = "btn_Banco1";
            this.btn_Banco1.Size = new System.Drawing.Size(219, 178);
            this.btn_Banco1.TabIndex = 1;
            this.btn_Banco1.Text = "Banco 1";
            this.btn_Banco1.UseVisualStyleBackColor = false;
            this.btn_Banco1.Click += new System.EventHandler(this.btn_Banco1_Click);
            // 
            // btn_Banco2
            // 
            this.btn_Banco2.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_Banco2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Banco2.Location = new System.Drawing.Point(328, 159);
            this.btn_Banco2.Name = "btn_Banco2";
            this.btn_Banco2.Size = new System.Drawing.Size(211, 178);
            this.btn_Banco2.TabIndex = 2;
            this.btn_Banco2.Text = "Banco 2";
            this.btn_Banco2.UseVisualStyleBackColor = false;
            this.btn_Banco2.Click += new System.EventHandler(this.btn_Banco2_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 386);
            this.Controls.Add(this.btn_Banco2);
            this.Controls.Add(this.btn_Banco1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn_Banco1;
        private Button btn_Banco2;
    }
}