namespace kutuphaneotomasyonu
{
    partial class SifreYenile
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
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_sifre1 = new System.Windows.Forms.Label();
            this.txt_sifre1 = new System.Windows.Forms.TextBox();
            this.txt_sifre2 = new System.Windows.Forms.TextBox();
            this.lbl_sifre2 = new System.Windows.Forms.Label();
            this.btn_sifredegis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_email.Location = new System.Drawing.Point(61, 78);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(235, 26);
            this.lbl_email.TabIndex = 0;
            this.lbl_email.Text = "Email adresinizi giriniz:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(303, 81);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(149, 22);
            this.txt_email.TabIndex = 0;
            // 
            // lbl_sifre1
            // 
            this.lbl_sifre1.AutoSize = true;
            this.lbl_sifre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre1.Location = new System.Drawing.Point(122, 170);
            this.lbl_sifre1.Name = "lbl_sifre1";
            this.lbl_sifre1.Size = new System.Drawing.Size(114, 26);
            this.lbl_sifre1.TabIndex = 2;
            this.lbl_sifre1.Text = "Yeni Şifre:";
            // 
            // txt_sifre1
            // 
            this.txt_sifre1.Location = new System.Drawing.Point(249, 175);
            this.txt_sifre1.Name = "txt_sifre1";
            this.txt_sifre1.Size = new System.Drawing.Size(149, 22);
            this.txt_sifre1.TabIndex = 1;
            this.txt_sifre1.TextChanged += new System.EventHandler(this.txt_sifre1_TextChanged);
            // 
            // txt_sifre2
            // 
            this.txt_sifre2.Location = new System.Drawing.Point(249, 223);
            this.txt_sifre2.Name = "txt_sifre2";
            this.txt_sifre2.Size = new System.Drawing.Size(149, 22);
            this.txt_sifre2.TabIndex = 2;
            this.txt_sifre2.TextChanged += new System.EventHandler(this.txt_sifre2_TextChanged);
            // 
            // lbl_sifre2
            // 
            this.lbl_sifre2.AutoSize = true;
            this.lbl_sifre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre2.Location = new System.Drawing.Point(61, 219);
            this.lbl_sifre2.Name = "lbl_sifre2";
            this.lbl_sifre2.Size = new System.Drawing.Size(175, 26);
            this.lbl_sifre2.TabIndex = 2;
            this.lbl_sifre2.Text = "Yeni Şifre tekrar:";
            // 
            // btn_sifredegis
            // 
            this.btn_sifredegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sifredegis.Location = new System.Drawing.Point(249, 283);
            this.btn_sifredegis.Name = "btn_sifredegis";
            this.btn_sifredegis.Size = new System.Drawing.Size(135, 38);
            this.btn_sifredegis.TabIndex = 3;
            this.btn_sifredegis.Text = "Şifre Değiştir";
            this.btn_sifredegis.UseVisualStyleBackColor = true;
            this.btn_sifredegis.Click += new System.EventHandler(this.btn_sifredegis_Click);
            // 
            // SifreYenile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sifredegis);
            this.Controls.Add(this.lbl_sifre2);
            this.Controls.Add(this.txt_sifre2);
            this.Controls.Add(this.lbl_sifre1);
            this.Controls.Add(this.txt_sifre1);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_email);
            this.Name = "SifreYenile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifreYenile";
            this.Load += new System.EventHandler(this.SifreYenile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_sifre1;
        private System.Windows.Forms.TextBox txt_sifre1;
        private System.Windows.Forms.TextBox txt_sifre2;
        private System.Windows.Forms.Label lbl_sifre2;
        private System.Windows.Forms.Button btn_sifredegis;
    }
}