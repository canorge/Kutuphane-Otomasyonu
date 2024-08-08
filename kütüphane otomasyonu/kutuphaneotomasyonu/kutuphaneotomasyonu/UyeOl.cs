using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneotomasyonu
{
    public partial class UyeOl : Form
    {
        SqlConnection baglanti = new SqlConnection("data source=CANORGE\\SQLEXPRESS; initial catalog=kutuphane; Integrated Security=True");
        public UyeOl()
        {
            InitializeComponent();
        }

        public void uyeol()
        {    
            string email=txt_email.Text;
            string yetki = "üye";
            string cinsiyet = " ";
            if (radio_erkek.Checked)
                cinsiyet = "erkek";
            else if (radio_kadin.Checked)
                cinsiyet = "kadın";
           
            if(string.IsNullOrEmpty(txt_ad.Text) || string.IsNullOrEmpty(txt_soyad.Text) || string.IsNullOrEmpty(txt_email.Text)
                || string.IsNullOrEmpty(txt_sifre.Text) || string.IsNullOrEmpty(maskedTextBox_telno.Text) ||
                cinsiyet==null) // Girilen bilgilerin boş olup olmadığının kontrolü
            {
                MessageBox.Show("Lütfen boş alan bırakmayın", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Emailmi(email))// girilen email geçerli ise
                {
                    baglanti.Open();
                    // kisi tablosuna yetkisi üye olan veri eklenir
                    SqlCommand cmd = new SqlCommand("insert into kisi(ad,soyad,email,sifre,telno,cinsiyet,yetki) " +
                        "values(@v1,@v2,@v3,@v4,@v5,@v6,@v7)", baglanti);
                    cmd.Parameters.AddWithValue("@v1", txt_ad.Text);
                    cmd.Parameters.AddWithValue("@v2", txt_soyad.Text);
                    cmd.Parameters.AddWithValue("@v3", txt_email.Text);
                    cmd.Parameters.AddWithValue("@v4", txt_sifre.Text);
                    cmd.Parameters.AddWithValue("@v5", maskedTextBox_telno.Text);
                    cmd.Parameters.AddWithValue("@v6", cinsiyet);
                    cmd.Parameters.AddWithValue("@v7", yetki);
                    int result = cmd.ExecuteNonQuery();

                    if (result == 1)
                        MessageBox.Show("Kayıt işlemi başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Kayıt olma işleminde hata", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Girilen e-posta adresi geçerli değil.", "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool Emailmi(string email)// verilen email adresinin doğru olup olmadığının kontrolü
        {
            try
            {
                var mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private void btn_kaydol_Click(object sender, EventArgs e)
        {
            uyeol();
        }

        private void btn_gerigel_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {
            txt_sifre.UseSystemPasswordChar= true;
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_ad.Clear();
            txt_soyad.Clear();
            txt_email.Clear();
            txt_sifre.Clear();
            maskedTextBox_telno.Clear();
            radio_erkek.Checked = false;
            radio_kadin.Checked = true;
        }

        private void UyeOl_Load(object sender, EventArgs e)
        {

        }
    }
}
