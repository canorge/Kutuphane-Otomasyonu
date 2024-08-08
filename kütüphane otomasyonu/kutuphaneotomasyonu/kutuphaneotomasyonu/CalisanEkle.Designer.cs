namespace kutuphaneotomasyonu
{
    partial class CalisanEkle
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
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_kaydol = new System.Windows.Forms.Button();
            this.radio_kadin = new System.Windows.Forms.RadioButton();
            this.radio_erkek = new System.Windows.Forms.RadioButton();
            this.maskedTextBox_telno = new System.Windows.Forms.MaskedTextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.lbl_cinsiyet = new System.Windows.Forms.Label();
            this.lbl_telno = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_gerigel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_temizle
            // 
            this.btn_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.Location = new System.Drawing.Point(414, 409);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(98, 31);
            this.btn_temizle.TabIndex = 8;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_kaydol
            // 
            this.btn_kaydol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydol.Location = new System.Drawing.Point(298, 409);
            this.btn_kaydol.Name = "btn_kaydol";
            this.btn_kaydol.Size = new System.Drawing.Size(98, 31);
            this.btn_kaydol.TabIndex = 7;
            this.btn_kaydol.Text = "Kayıt Ol";
            this.btn_kaydol.UseVisualStyleBackColor = true;
            this.btn_kaydol.Click += new System.EventHandler(this.btn_kaydol_Click);
            // 
            // radio_kadin
            // 
            this.radio_kadin.AutoSize = true;
            this.radio_kadin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_kadin.Location = new System.Drawing.Point(389, 349);
            this.radio_kadin.Name = "radio_kadin";
            this.radio_kadin.Size = new System.Drawing.Size(72, 24);
            this.radio_kadin.TabIndex = 6;
            this.radio_kadin.TabStop = true;
            this.radio_kadin.Text = "Kadın";
            this.radio_kadin.UseVisualStyleBackColor = true;
            // 
            // radio_erkek
            // 
            this.radio_erkek.AutoSize = true;
            this.radio_erkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_erkek.Location = new System.Drawing.Point(389, 323);
            this.radio_erkek.Name = "radio_erkek";
            this.radio_erkek.Size = new System.Drawing.Size(72, 24);
            this.radio_erkek.TabIndex = 5;
            this.radio_erkek.TabStop = true;
            this.radio_erkek.Text = "Erkek";
            this.radio_erkek.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox_telno
            // 
            this.maskedTextBox_telno.Location = new System.Drawing.Point(389, 271);
            this.maskedTextBox_telno.Mask = "(999) 000-0000";
            this.maskedTextBox_telno.Name = "maskedTextBox_telno";
            this.maskedTextBox_telno.Size = new System.Drawing.Size(91, 22);
            this.maskedTextBox_telno.TabIndex = 4;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(389, 224);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(123, 22);
            this.txt_sifre.TabIndex = 3;
            this.txt_sifre.TextChanged += new System.EventHandler(this.txt_sifre_TextChanged);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(389, 171);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(123, 22);
            this.txt_email.TabIndex = 2;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(389, 120);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(123, 22);
            this.txt_soyad.TabIndex = 1;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(389, 74);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(123, 22);
            this.txt_ad.TabIndex = 0;
            // 
            // lbl_cinsiyet
            // 
            this.lbl_cinsiyet.AutoSize = true;
            this.lbl_cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cinsiyet.Location = new System.Drawing.Point(208, 323);
            this.lbl_cinsiyet.Name = "lbl_cinsiyet";
            this.lbl_cinsiyet.Size = new System.Drawing.Size(88, 25);
            this.lbl_cinsiyet.TabIndex = 5;
            this.lbl_cinsiyet.Text = "Cinsiyet:";
            // 
            // lbl_telno
            // 
            this.lbl_telno.AutoSize = true;
            this.lbl_telno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_telno.Location = new System.Drawing.Point(208, 271);
            this.lbl_telno.Name = "lbl_telno";
            this.lbl_telno.Size = new System.Drawing.Size(172, 25);
            this.lbl_telno.TabIndex = 6;
            this.lbl_telno.Text = "Telefon Numarası:";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre.Location = new System.Drawing.Point(208, 220);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(58, 25);
            this.lbl_sifre.TabIndex = 7;
            this.lbl_sifre.Text = "Şifre:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_email.Location = new System.Drawing.Point(208, 171);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(66, 25);
            this.lbl_email.TabIndex = 8;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soyad.Location = new System.Drawing.Point(208, 120);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(75, 25);
            this.lbl_soyad.TabIndex = 9;
            this.lbl_soyad.Text = "Soyad:";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ad.Location = new System.Drawing.Point(208, 72);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(43, 25);
            this.lbl_ad.TabIndex = 10;
            this.lbl_ad.Text = "Ad:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_gerigel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 55);
            this.panel1.TabIndex = 20;
            // 
            // btn_gerigel
            // 
            this.btn_gerigel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gerigel.Location = new System.Drawing.Point(0, 0);
            this.btn_gerigel.Name = "btn_gerigel";
            this.btn_gerigel.Size = new System.Drawing.Size(80, 55);
            this.btn_gerigel.TabIndex = 0;
            this.btn_gerigel.Text = "<";
            this.btn_gerigel.UseVisualStyleBackColor = true;
            this.btn_gerigel.Click += new System.EventHandler(this.btn_gerigel_Click);
            // 
            // CalisanEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_kaydol);
            this.Controls.Add(this.radio_kadin);
            this.Controls.Add(this.radio_erkek);
            this.Controls.Add(this.maskedTextBox_telno);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.lbl_cinsiyet);
            this.Controls.Add(this.lbl_telno);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.lbl_ad);
            this.Name = "CalisanEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalisanEkle";
            this.Load += new System.EventHandler(this.CalisanEkle_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_kaydol;
        private System.Windows.Forms.RadioButton radio_kadin;
        private System.Windows.Forms.RadioButton radio_erkek;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telno;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label lbl_cinsiyet;
        private System.Windows.Forms.Label lbl_telno;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_gerigel;
    }
}