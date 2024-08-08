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
    public partial class kitapiadeet : Form
    {
        SqlConnection baglanti = new SqlConnection("data source=CANORGE\\SQLEXPRESS; initial catalog=kutuphane; Integrated Security=True");
        public kitapiadeet()
        {
            InitializeComponent();
        }

        public void iadeet()
        {
            int id = 0;
            baglanti.Open();
            // bilgileri girilen kitabın idsini getirme
            SqlCommand idbul = new SqlCommand("select id from kitap where kitapad=@v2 and kitapyazari=@v3 and tur=@v4",baglanti);
            idbul.Parameters.AddWithValue("@v2", txt_kitapad.Text.ToLower());
            idbul.Parameters.AddWithValue("@v3", txt_yazarad.Text.ToLower());
            idbul.Parameters.AddWithValue("@v4", txt_tur.Text.ToLower());
            id=int.Parse(idbul.ExecuteScalar().ToString());

            //bilgileri girilen kitap kütüphanede var mı kontolü
            SqlCommand kontrol1 = new SqlCommand("select 1 from kitap where id=@1 and kitapad=@2 and kitapyazari=@3 and tur=@4", baglanti);
            kontrol1.Parameters.AddWithValue("@1",id);
            kontrol1.Parameters.AddWithValue("@2", txt_kitapad.Text.ToLower());
            kontrol1.Parameters.AddWithValue("@3", txt_yazarad.Text.ToLower());
            kontrol1.Parameters.AddWithValue("@4", txt_tur.Text .ToLower());
            if(kontrol1.ExecuteScalar() != null)// kitap kütüphanede varsa
            {
                // kitap emanet alınmış mı kontrolü
                SqlCommand kontrol2 = new SqlCommand("select 1 from emnaetkitaplar where id=@a and ad=@b and yazar=@c and tur=@d", baglanti);
                kontrol2.Parameters.AddWithValue("@a", id);
                kontrol2.Parameters.AddWithValue("@b", txt_kitapad.Text.ToLower());
                kontrol2.Parameters.AddWithValue("@c", txt_yazarad.Text.ToLower());
                kontrol2.Parameters.AddWithValue("@d",txt_tur.Text.ToLower());
                if(kontrol2.ExecuteScalar() != null)
                {
                    // kitap emanet alınmış ise emanet kitaplar listesinden silme 
                    SqlCommand cmd = new SqlCommand("delete from emnaetkitaplar where id=@a and ad=@b and yazar=@c and tur=@d", baglanti);
                    cmd.Parameters.AddWithValue("@a", id);
                    cmd.Parameters.AddWithValue("@b", txt_kitapad.Text.ToLower());
                    cmd.Parameters.AddWithValue("@c", txt_yazarad.Text.ToLower());
                    cmd.Parameters.AddWithValue("@d", txt_tur.Text.ToLower());
                    int result=cmd.ExecuteNonQuery();
                    if(result == 1)
                    {
                        MessageBox.Show("İade işlemi başarılı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    // kitaplar tablosunda iade edilen kitabın adetinin 1 arttırılması
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

        private void button1_Click(object sender, EventArgs e)
        {
            UyeSayfasi us=new UyeSayfasi();
            us.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_tur_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_yazarad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_kitapad_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_tur_Click(object sender, EventArgs e)
        {

        }

        private void lbl_yazar_Click(object sender, EventArgs e)
        {

        }

        private void lbl_kitapad_Click(object sender, EventArgs e)
        {

        }

        private void kitapiadeet_Load(object sender, EventArgs e)
        {

        }
    }
}
