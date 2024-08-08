namespace kutuphaneotomasyonu
{
    partial class UyeOl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeOl));
            this.lbl_ad = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.maskedTextBox_telno = new System.Windows.Forms.MaskedTextBox();
            this.lbl_telno = new System.Windows.Forms.Label();
            this.lbl_cinsiyet = new System.Windows.Forms.Label();
            this.radio_erkek = new System.Windows.Forms.RadioButton();
            this.radio_kadin = new System.Windows.Forms.RadioButton();
            this.btn_kaydol = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_gerigel = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_ad.Location = new System.Drawing.Point(159, 101);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(46, 25);
            this.lbl_ad.TabIndex = 0;
            this.lbl_ad.Text = "AD:";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(211, 104);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 22);
            this.txt_ad.TabIndex = 0;
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soyad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_soyad.Location = new System.Drawing.Point(116, 144);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(89, 25);
            this.lbl_soyad.TabIndex = 0;
            this.lbl_soyad.Text = "SOYAD:";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(211, 147);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(100, 22);
            this.txt_soyad.TabIndex = 1;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_email.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_email.Location = new System.Drawing.Point(127, 188);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(78, 25);
            this.lbl_email.TabIndex = 0;
            this.lbl_email.Text = "EMAİL:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(211, 192);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 22);
            this.txt_email.TabIndex = 2;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_sifre.Location = new System.Drawing.Point(130, 238);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(75, 25);
            this.lbl_sifre.TabIndex = 0;
            this.lbl_sifre.Text = "ŞİFRE:";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(211, 238);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(100, 22);
            this.txt_sifre.TabIndex = 3;
            this.txt_sifre.TextChanged += new System.EventHandler(this.txt_sifre_TextChanged);
            // 
            // maskedTextBox_telno
            // 
            this.maskedTextBox_telno.Location = new System.Drawing.Point(211, 285);
            this.maskedTextBox_telno.Mask = "(999) 000-0000";
            this.maskedTextBox_telno.Name = "maskedTextBox_telno";
            this.maskedTextBox_telno.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox_telno.TabIndex = 4;
            // 
            // lbl_telno
            // 
            this.lbl_telno.AutoSize = true;
            this.lbl_telno.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_telno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_telno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_telno.Location = new System.Drawing.Point(115, 285);
            this.lbl_telno.Name = "lbl_telno";
            this.lbl_telno.Size = new System.Drawing.Size(90, 25);
            this.lbl_telno.TabIndex = 0;
            this.lbl_telno.Text = "TEL NO:";
            // 
            // lbl_cinsiyet
            // 
            this.lbl_cinsiyet.AutoSize = true;
            this.lbl_cinsiyet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cinsiyet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_cinsiyet.Location = new System.Drawing.Point(95, 338);
            this.lbl_cinsiyet.Name = "lbl_cinsiyet";
            this.lbl_cinsiyet.Size = new System.Drawing.Size(110, 25);
            this.lbl_cinsiyet.TabIndex = 0;
            this.lbl_cinsiyet.Text = "CİNSİYET:";
            // 
            // radio_erkek
            // 
            this.radio_erkek.AutoSize = true;
            this.radio_erkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_erkek.Location = new System.Drawing.Point(228, 334);
            this.radio_erkek.Name = "radio_erkek";
            this.radio_erkek.Size = new System.Drawing.Size(83, 29);
            this.radio_erkek.TabIndex = 5;
            this.radio_erkek.TabStop = true;
            this.radio_erkek.Text = "Erkek";
            this.radio_erkek.UseVisualStyleBackColor = true;
            // 
            // radio_kadin
            // 
            this.radio_kadin.AutoSize = true;
            this.radio_kadin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_kadin.Location = new System.Drawing.Point(228, 369);
            this.radio_kadin.Name = "radio_kadin";
            this.radio_kadin.Size = new System.Drawing.Size(84, 29);
            this.radio_kadin.TabIndex = 6;
            this.radio_kadin.TabStop = true;
            this.radio_kadin.Text = "Kadın";
            this.radio_kadin.UseVisualStyleBackColor = true;
            // 
            // btn_kaydol
            // 
            this.btn_kaydol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydol.Location = new System.Drawing.Point(135, 433);
            this.btn_kaydol.Name = "btn_kaydol";
            this.btn_kaydol.Size = new System.Drawing.Size(102, 37);
            this.btn_kaydol.TabIndex = 7;
            this.btn_kaydol.Text = "KAYDOL";
            this.btn_kaydol.UseVisualStyleBackColor = true;
            this.btn_kaydol.Click += new System.EventHandler(this.btn_kaydol_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_gerigel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 54);
            this.panel1.TabIndex = 5;
            // 
            // btn_gerigel
            // 
            this.btn_gerigel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_gerigel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gerigel.Location = new System.Drawing.Point(0, 0);
            this.btn_gerigel.Name = "btn_gerigel";
            this.btn_gerigel.Size = new System.Drawing.Size(75, 54);
            this.btn_gerigel.TabIndex = 0;
            this.btn_gerigel.Text = "<";
            this.btn_gerigel.UseVisualStyleBackColor = false;
            this.btn_gerigel.Click += new System.EventHandler(this.btn_gerigel_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.Location = new System.Drawing.Point(256, 433);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(102, 37);
            this.btn_temizle.TabIndex = 8;
            this.btn_temizle.Text = "TEMZİLE";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // UyeOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(914, 553);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.btn_kaydol);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.radio_kadin);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.radio_erkek);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.lbl_telno);
            this.Controls.Add(this.lbl_cinsiyet);
            this.Controls.Add(this.maskedTextBox_telno);
            this.Name = "UyeOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UyeOl";
            this.Load += new System.EventHandler(this.UyeOl_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telno;
        private System.Windows.Forms.Label lbl_telno;
        private System.Windows.Forms.Label lbl_cinsiyet;
        private System.Windows.Forms.RadioButton radio_erkek;
        private System.Windows.Forms.RadioButton radio_kadin;
        private System.Windows.Forms.Button btn_kaydol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_gerigel;
        private System.Windows.Forms.Button btn_temizle;
    }
}