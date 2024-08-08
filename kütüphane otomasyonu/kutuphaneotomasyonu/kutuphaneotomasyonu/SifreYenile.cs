using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneotomasyonu
{
    public partial class SifreYenile : Form
    {
        SqlConnection baglanti = new SqlConnection("data source=CANORGE\\SQLEXPRESS; initial catalog=kutuphane; Integrated Security=True");
        public SifreYenile()
        {
            InitializeComponent();
        }

        private void btn_sifredegis_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            // girilen emaile ait kayıt var mı kontrolü
            SqlCommand kontrol1 = new SqlCommand("select 1 from kisi where email=@v1", baglanti);
            kontrol1.Parameters.AddWithValue("@v1",txt_email.Text);
            
            if(kontrol1.ExecuteScalar() != null)// kayıt varsa
            {
                if(txt_sifre1.Text ==txt_sifre2.Text)// girilen iki şifre aynı ise
                {
                    // kişinin şifre bilgisi değiştirilir
                    SqlCommand cmd = new SqlCommand("update kisi set sifre=@v2 where email=@v3", baglanti);
                    cmd.Parameters.AddWithValue("@v2", txt_sifre2.Text);
                    cmd.Parameters.AddWithValue("@v3", txt_email.Text);
                    int result= cmd.ExecuteNonQuery();
                    if(result == 1)
                    {
                        MessageBox.Show("Şifre Değiştirildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        Form1  form1 = new Form1();
                        form1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Şifre Değişim İşleminde Hata","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Şifrelerin aynı olduğundan emin olun", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bu emaile ait hesap bulunamadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();

        }

        private void txt_sifre1_TextChanged(object sender, EventArgs e)
        {
            txt_sifre1.UseSystemPasswordChar = true;    
        }

        private void txt_sifre2_TextChanged(object sender, EventArgs e)
        {
            txt_sifre2.UseSystemPasswordChar=true;
        }

        private void SifreYenile_Load(object sender, EventArgs e)
        {

        }
    }
}
