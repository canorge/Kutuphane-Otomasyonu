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
    public partial class emanetaladminicin : Form
    {
        SqlConnection baglanti = new SqlConnection("data source=CANORGE\\SQLEXPRESS; initial catalog=kutuphane; Integrated Security=True");
        public emanetaladminicin()
        {
            InitializeComponent();
        }

        private void btn_emanetal_Click(object sender, EventArgs e)
        {
            // kitabın ID bilgisini getirme
            int id = 0;
            baglanti.Open();
            SqlCommand idbul = new SqlCommand("select id from kitap where kitapad=@v2 and kitapyazari=@v3 and tur=@v4", baglanti);
            idbul.Parameters.AddWithValue("@v2", txt_kitapad.Text.ToLower());
            idbul.Parameters.AddWithValue("@v3", txt_yazarad.Text.ToLower());
            idbul.Parameters.AddWithValue("@v4", txt_tur.Text.ToLower());
            id = int.Parse(idbul.ExecuteScalar().ToString());

            // Bilgileri girilen kitabın kütüphanede olup olmadığını kontrolü
            SqlCommand kontrol = new SqlCommand("select 1 from kitap where id=@id and kitapad=@v1 and kitapyazari=@v2 and tur=@v3", baglanti);
            kontrol.Parameters.AddWithValue("@v1", txt_kitapad.Text.ToLower());
            kontrol.Parameters.AddWithValue("@v2", txt_yazarad.Text.ToLower());
            kontrol.Parameters.AddWithValue("@v3", txt_tur.Text.ToLower());
            kontrol.Parameters.AddWithValue("@id", id);

            if (kontrol.ExecuteScalar() != null)// kitap varsa
            { // kitabın adet bilgisi sorgulanır
                SqlCommand kontrol2 = new SqlCommand("select adet from kitap where id=@vid and kitapad=@v1 and kitapyazari=@v2 and tur=@v3", baglanti);
                kontrol2.Parameters.AddWithValue("@v1", txt_kitapad.Text.ToLower());
                kontrol2.Parameters.AddWithValue("@v2", txt_yazarad.Text.ToLower());
                kontrol2.Parameters.AddWithValue("@v3", txt_tur.Text.ToLower());
                kontrol2.Parameters.AddWithValue("@vid", id);
                if (int.Parse(kontrol2.ExecuteScalar().ToString()) == 0)// adet 0 ise kitapları başkaları emanet almıştır
                {
                    MessageBox.Show("Malesef bu kitap kütüphanede yok", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else//  değilse kitap vardır emanet kitaplar tablosuna kitap eklenir
                {
                    SqlCommand cmd = new SqlCommand("insert into emnaetkitaplar(id,ad,yazar,tur) values(@kid,@vad,@vyazar,@vtur)", baglanti);
                    cmd.Parameters.AddWithValue("@kid", id);
                    cmd.Parameters.AddWithValue("@vad", txt_kitapad.Text.ToLower());
                    cmd.Parameters.AddWithValue("@vyazar", txt_yazarad.Text.ToLower());
                    cmd.Parameters.AddWithValue("@vtur", txt_tur.Text.ToLower());
                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        // kitap emanet alınırsa kitabın adeti 1 azaltılır
                        MessageBox.Show("Kitabınızı alabilirsiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SqlCommand cmd2 = new SqlCommand("update kitap set adet=adet-1 where id=@kitapid", baglanti);
                        cmd2.Parameters.AddWithValue("@kitapid", id);
                        cmd2.ExecuteNonQuery();

                    }

                }
            }
            else
                MessageBox.Show("Aradığınız kitap kütüphanede bulunmamaktadır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            baglanti.Close();
            datagriedwieveyazdirma();
        }
        public void datagriedwieveyazdirma()// datagridviewe kütüphanedeki kitap bilgilerini girme
        {
            baglanti.Open();

            SqlCommand cmd = new SqlCommand("select kitapad,kitapyazari,tur,adet from kitap", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            baglanti.Close();
        }

        private void emanetaladminicin_Load(object sender, EventArgs e)
        {
            datagriedwieveyazdirma();
        }

        private void btn_gerigel_Click(object sender, EventArgs e)
        {
            AdminSayfasi ad=new AdminSayfasi();
            ad.Show();
            this.Hide();
        }
    }
}
