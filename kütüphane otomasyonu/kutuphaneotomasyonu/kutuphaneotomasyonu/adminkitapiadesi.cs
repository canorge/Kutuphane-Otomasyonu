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
    public partial class adminkitapiadesi : Form
    {
        SqlConnection baglanti = new SqlConnection("data source=CANORGE\\SQLEXPRESS; initial catalog=kutuphane; Integrated Security=True");
        public adminkitapiadesi()
        {
            InitializeComponent();
        }
        public void iadeet()
        {
            int id = 0;
            baglanti.Open();
            // bilgileri girilen kitabın idsini getirme
            SqlCommand idbul = new SqlCommand("select id from kitap where kitapad=@v2 and kitapyazari=@v3 and tur=@v4", baglanti);
            idbul.Parameters.AddWithValue("@v2", txt_kitapad.Text.ToLower());
            idbul.Parameters.AddWithValue("@v3", txt_yazarad.Text.ToLower());
            idbul.Parameters.AddWithValue("@v4", txt_tur.Text.ToLower());
            id = int.Parse(idbul.ExecuteScalar().ToString());

            // bilgileri girilen kitap var mı kontrolü
            SqlCommand kontrol1 = new SqlCommand("select 1 from kitap where id=@1 and kitapad=@2 and kitapyazari=@3 and tur=@4", baglanti);
            kontrol1.Parameters.AddWithValue("@1", id);
            kontrol1.Parameters.AddWithValue("@2", txt_kitapad.Text.ToLower());
            kontrol1.Parameters.AddWithValue("@3", txt_yazarad.Text.ToLower());
            kontrol1.Parameters.AddWithValue("@4", txt_tur.Text.ToLower());
            if (kontrol1.ExecuteScalar() != null)// kitap varsa
            {
                // emanet alınmış mı kontrolü
                SqlCommand kontrol2 = new SqlCommand("select 1 from emnaetkitaplar where id=@a and ad=@b and yazar=@c and tur=@d", baglanti);
                kontrol2.Parameters.AddWithValue("@a", id);
                kontrol2.Parameters.AddWithValue("@b", txt_kitapad.Text.ToLower());
                kontrol2.Parameters.AddWithValue("@c", txt_yazarad.Text.ToLower());
                kontrol2.Parameters.AddWithValue("@d", txt_tur.Text.ToLower());
                if (kontrol2.ExecuteScalar() != null)// alınmış ise
                {
                    // verinin emanet kitaplar tablosundan silinmesi
                    SqlCommand cmd = new SqlCommand("delete from emnaetkitaplar where id=@a and ad=@b and yazar=@c and tur=@d", baglanti);
                    cmd.Parameters.AddWithValue("@a", id);
                    cmd.Parameters.AddWithValue("@b", txt_kitapad.Text.ToLower());
                    cmd.Parameters.AddWithValue("@c", txt_yazarad.Text.ToLower());
                    cmd.Parameters.AddWithValue("@d", txt_tur.Text.ToLower());
                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("İade işlemi başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    // kitap tablosundaki verinin adet değerinin 1 arttırılması
                    SqlCommand adetarttir = new SqlCommand("update kitap set adet=adet+1 where id=@id and kitapad=@ad and kitapyazari=@yazar and tur=@tur", baglanti);
                    adetarttir.Parameters.AddWithValue("@id", id);
                    adetarttir.Parameters.AddWithValue("@ad", txt_kitapad.Text.ToLower());
                    adetarttir.Parameters.AddWithValue("@yazar", txt_yazarad.Text.ToLower());
                    adetarttir.Parameters.AddWithValue("@tur", txt_tur.Text.ToLower());
                    adetarttir.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Kütüphanemizden bu kitap alınmamıştır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Kütüphanemizden bu kitap alınmamıştır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
        }
        private void btn_iadeet_Click(object sender, EventArgs e)
        {
            iadeet();
        }

        private void btn_gerigel_Click(object sender, EventArgs e)
        {
            AdminSayfasi adminSayfasi = new AdminSayfasi();
            adminSayfasi.Show();
            this.Hide();
        }

        private void adminkitapiadesi_Load(object sender, EventArgs e)
        {

        }
    }
}
