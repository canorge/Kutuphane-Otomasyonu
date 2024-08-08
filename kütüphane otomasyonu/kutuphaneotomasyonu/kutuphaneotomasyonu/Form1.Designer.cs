namespace kutuphaneotomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_eposta = new System.Windows.Forms.Label();
            this.txt_eposta = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.btn_girisyap = new System.Windows.Forms.Button();
            this.lbl_uyeol = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.btn_kayıtol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_eposta
            // 
            this.lbl_eposta.AutoSize = true;
            this.lbl_eposta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_eposta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_eposta.Location = new System.Drawing.Point(170, 120);
            this.lbl_eposta.Name = "lbl_eposta";
            this.lbl_eposta.Size = new System.Drawing.Size(112, 39);
            this.lbl_eposta.TabIndex = 0;
            this.lbl_eposta.Text = "Email:";
            // 
            // txt_eposta
            // 
            this.txt_eposta.Location = new System.Drawing.Point(305, 135);
            this.txt_eposta.Name = "txt_eposta";
            this.txt_eposta.Size = new System.Drawing.Size(232, 22);
            this.txt_eposta.TabIndex = 0;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre.Location = new System.Drawing.Point(186, 172);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(96, 39);
            this.lbl_sifre.TabIndex = 2;
            this.lbl_sifre.Text = "Şifre:";
            this.lbl_sifre.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_girisyap
            // 
            this.btn_girisyap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_girisyap.Location = new System.Drawing.Point(316, 327);
            this.btn_girisyap.Name = "btn_girisyap";
            this.btn_girisyap.Size = new System.Drawing.Size(111, 38);
            this.btn_girisyap.TabIndex = 2;
            this.btn_girisyap.Text = "Giriş Yap";
            this.btn_girisyap.UseVisualStyleBackColor = true;
            this.btn_girisyap.Click += new System.EventHandler(this.btn_girisyap_Click);
            // 
            // lbl_uyeol
            // 
            this.lbl_uyeol.AutoSize = true;
            this.lbl_uyeol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_uyeol.Location = new System.Drawing.Point(572, 282);
            this.lbl_uyeol.Name = "lbl_uyeol";
            this.lbl_uyeol.Size = new System.Drawing.Size(204, 29);
            this.lbl_uyeol.TabIndex = 5;
            this.lbl_uyeol.Text = "Üye Değil Misin?";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(336, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "şifremi unuttum";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(305, 187);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(232, 22);
            this.txt_sifre.TabIndex = 1;
            this.txt_sifre.TextChanged += new System.EventHandler(this.txt_sifre_TextChanged_1);
            // 
            // btn_kayıtol
            // 
            this.btn_kayıtol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayıtol.Location = new System.Drawing.Point(594, 327);
            this.btn_kayıtol.Name = "btn_kayıtol";
            this.btn_kayıtol.Size = new System.Drawing.Size(132, 38);
            this.btn_kayıtol.TabIndex = 3;
            this.btn_kayıtol.Text = "Kayıt Ol";
            this.btn_kayıtol.UseVisualStyleBackColor = true;
            this.btn_kayıtol.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(926, 480);
            this.Controls.Add(this.btn_kayıtol);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_uyeol);
            this.Controls.Add(this.btn_girisyap);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.txt_eposta);
            this.Controls.Add(this.lbl_eposta);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_eposta;
        private System.Windows.Forms.TextBox txt_eposta;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Button btn_girisyap;
        private System.Windows.Forms.Label lbl_uyeol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Button btn_kayıtol;
    }
}

