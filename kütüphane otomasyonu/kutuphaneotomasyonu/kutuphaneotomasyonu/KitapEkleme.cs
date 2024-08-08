using kutuphaneotomasyonu.model;
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
    public partial class KitapEkleme : Form
    {
        SqlConnection baglanti = new SqlConnection("data source=CANORGE\\SQLEXPRESS; initial catalog=kutuphane; Integrated Security=True");
        public KitapEkleme()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void KitapEkle()
        {
            baglanti.Open();
            // Bİlgileri girilen kitap kütüphanede var mı kontolü
            SqlCommand kontrol = new SqlCommand("select 1 from kitap where kitapad=@v1 and kitapyazari=@v2 and sayfasayisi=@v3 and tur=@v4", baglanti);
            kontrol.Parameters.AddWithValue("@v1", txt_kitapad.Text);
            kontrol.Parameters.AddWithValue("@v2", txt_yazarad.Text);
            kontrol.Parameters.AddWithValue("@v3", int.Parse(txt_sayfasayisi.Text));
            kontrol.Parameters.AddWithValue("@v4", txt_tur.Text);

            if(kontrol.ExecuteScalar()==null)
            {
                // kitap yoksa adeti 1 olarak kütüphaneye eklenir
                int adet = 1;
                SqlCommand ekle = new SqlCommand("insert into kitap(kitapad,kitapyazari,sayfasayisi,tur,adet) values(@ad,@yazari,@sayi,@tur,@adet)", baglanti);
                ekle.Parameters.AddWithValue("@ad", txt_kitapad.Text);
                ekle.Parameters.AddWithValue("@yazari", txt_yazarad.Text);
                ekle.Parameters.AddWithValue("@sayi",int.Parse(txt_sayfasayisi.Text));
                ekle.Parameters.AddWithValue("@tur",txt_tur.Text);
                ekle.Parameters.AddWithValue("@adet", adet);
                int sonuc1=ekle.ExecuteNonQuery();
                if(sonuc1==1)
                {
                    MessageBox.Show("Ekleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ekleme Başarısız","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // varsa adeti 1 arttırılır
                SqlCommand arttir = new SqlCommand("update kitap set adet=adet+1 where kitapad=@a and kitapyazari=@b and sayfasayisi=@c and tur=@d", baglanti);
                arttir.Parameters.AddWithValue("@a", txt_kitapad.Text);
                arttir.Parameters.AddWithValue("@b", txt_yazarad.Text);
                arttir.Parameters.AddWithValue("@c", int.Parse(txt_sayfasayisi.Text));
                arttir.Parameters.AddWithValue("@d", txt_tur.Text);
                var sonuc2 = arttir.ExecuteNonQuery();
                if (sonuc2 == 1)
                {
                    MessageBox.Show("Adet arttı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("HATA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            baglanti.Close();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            
            KitapEkle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminSayfasi ad = new AdminSayfasi();
            ad.Show();
            this.Hide();
        }

        private void btn_temzile_Click(object sender, EventArgs e)
        {
            txt_kitapad.Clear();    
            txt_yazarad.Clear();
            txt_sayfasayisi.Clear();
            txt_tur.Clear();
        }

        private void KitapEkleme_Load(object sender, EventArgs e)
        {

        }
    }
}
