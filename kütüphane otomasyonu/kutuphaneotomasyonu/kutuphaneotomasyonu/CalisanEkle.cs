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
    public partial class CalisanEkle : Form
    {
        SqlConnection baglanti = new SqlConnection("data source=CANORGE\\SQLEXPRESS; initial catalog=kutuphane;Integrated Security=True");
        public CalisanEkle()
        {
            InitializeComponent();
        }
        public void calisanekle()// Çalışan ekleme fonksiyonu
        {
            baglanti.Open();
            string email = txt_email.Text;
            string yetki = "admin";
            string cinsiyet = " ";
            if (radio_erkek.Checked)
            {
                cinsiyet = "erkek";
            }
            else if (radio_kadin.Checked)
            {
                cinsiyet = "kadin";
            }
            // bilgilerin girilip girilmediği kontrolü
            if(string.IsNullOrEmpty(txt_ad.Text) || string.IsNullOrEmpty(txt_email.Text) || string.IsNullOrEmpty(txt_soyad.Text)
                || string.IsNullOrEmpty(txt_sifre.Text) || string.IsNullOrEmpty(maskedTextBox_telno.Text) || cinsiyet==null)
            {
                MessageBox.Show("Boş alan bırakmadığınızdan emin olun", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Emailmi(email))// girilen email geçerli ise çalışan eklenir
                {
                    // çalışan ekleme sorgusu
                    SqlCommand cmd = new SqlCommand("insert into kisi(ad,soyad,email,sifre,telno,cinsiyet,yetki) values(@1,@2,@3,@4,@5,@6,@7)", baglanti);
                    cmd.Parameters.AddWithValue("@1", txt_ad.Text);
                    cmd.Parameters.AddWithValue("@2", txt_soyad.Text);
                    cmd.Parameters.AddWithValue("@3", txt_email.Text);
                    cmd.Parameters.AddWithValue("@4", txt_sifre.Text);
                    cmd.Parameters.AddWithValue("@5", maskedTextBox_telno.Text);
                    cmd.Parameters.AddWithValue("@6", cinsiyet);
                    cmd.Parameters.AddWithValue("@7", yetki);
                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                        MessageBox.Show("Çalışan eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Ekleme başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Girilen e-posta adresi geçerli değil.", "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }

            baglanti.Close();
        }
        public bool Emailmi(string email)// Verilen bir email bilgisinin geçerli bir email olup olmadığının kontrolü
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
            calisanekle();
        }

        private void btn_gerigel_Click(object sender, EventArgs e)
        {
            AdminSayfasi ad = new AdminSayfasi();
            ad.Show();
            this.Hide();
        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {
            txt_sifre.UseSystemPasswordChar = true;
        }

        private void btn_temizle_Click(object sender, EventArgs e)// bütün alanların temizlenmesi
        {
            txt_ad.Clear();
            txt_soyad.Clear();
            txt_email.Clear();
            txt_sifre.Clear();
            maskedTextBox_telno.Clear();
            radio_erkek.Checked = false;
            radio_kadin.Checked = false;
        }

        private void CalisanEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
