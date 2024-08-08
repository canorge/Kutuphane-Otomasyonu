using kutuphaneotomasyonu.model;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace kutuphaneotomasyonu
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti =new SqlConnection("data source=CANORGE\\SQLEXPRESS; initial catalog=kutuphane;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // Giriş Yap butonu
        private void btn_girisyap_Click(object sender, EventArgs e)
        {
           
            string email=txt_eposta.Text;

            // Email alanı veya şifre alanı boş ise hata mesajı veriyor
            if (string.IsNullOrEmpty(txt_eposta.Text) || string.IsNullOrEmpty(txt_sifre.Text))
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Eğer bütün alanlar dolu ise girilen Email adresini kontrol etmek için Emailmi fonksiyonunu çağırıyor
                if (Emailmi(email))
                {
                    // Doğru ise veritabanından böyle bir kişi var mı varsa admin mi üye mi kontrolü
                    baglanti.Open();
                    Kisi k = new Kisi();
                    SqlCommand cmd = new SqlCommand("select yetki from kisi  where email=@email and sifre=@sifre", baglanti);
                    cmd.Parameters.AddWithValue("@email", txt_eposta.Text);
                    cmd.Parameters.AddWithValue("@sifre", txt_sifre.Text);

                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    while (reader.Read())
                    {

                        k.yetki = reader["yetki"].ToString();
                    }

                    if (k.yetki == "admin") // Eğer giriş yapmaya çalışan kişi admin ise admin sayfasına yönlendiriyor
                    {
                        AdminSayfasi ad = new AdminSayfasi();
                        ad.Show();
                        this.Hide();
                    }
                    else if (k.yetki == "üye") // giriş yapmaya çalışan kişi üye ise üye sayfasına yönlendiriyor
                    {
                        UyeSayfasi us = new UyeSayfasi();
                        us.Show();
                        this.Hide();
                    }
                    else // Eğer böyle bir kişi kayıtlı değilse hata mesajı veriyor
                    {
                        MessageBox.Show("Böyle bir kayıt yok", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Girilen e-posta adresi geçerli değil.", "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            baglanti.Close();

        }
        public bool Emailmi(string email) // girilen emailin doğru bir email adresi olup olmadığının kontolünü yapan fonksiyon
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

            
        private void btn_uyeol_Click(object sender, EventArgs e)
        {
          
        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            SifreYenile sy=new SifreYenile();
            sy.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_sifre_TextChanged_1(object sender, EventArgs e)
        {
            txt_sifre.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UyeOl uyeOl = new UyeOl();
            uyeOl.Show();
            this.Hide();
        }
    }
}
