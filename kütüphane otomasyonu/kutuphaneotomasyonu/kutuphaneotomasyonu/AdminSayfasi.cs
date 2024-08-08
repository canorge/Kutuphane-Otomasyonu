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
    public partial class AdminSayfasi : Form
    {
        SqlConnection baglanti = new SqlConnection("data source=CANORGE\\SQLEXPRESS; initial catalog=kutuphane; user id=sa; password=1");
        public AdminSayfasi()
        {
            InitializeComponent();
        }


        // gerekli sayfalara yönlendirme
        private void btn_kitaplistele_Click(object sender, EventArgs e)
        {
            kitaplistesiadminicin kl=new kitaplistesiadminicin();
            kl.Show();
            this.Hide();   
        }

        private void btn_uyelistele_Click(object sender, EventArgs e)
        {
            UyeListesi ul=new UyeListesi();
            ul.Show();
            this.Hide();
        }


        private void btn_calisanekle_Click(object sender, EventArgs e)
        {
            CalisanEkle ce=new CalisanEkle();
            ce.Show();
            this.Hide();
        }


        private void btn_kitapekle_Click(object sender, EventArgs e)
        {
            KitapEkleme ke=new KitapEkleme();
            ke.Show();
            this.Hide();
        }

        private void btn_kitapiade_Click(object sender, EventArgs e)
        {
            adminkitapiadesi kitapiadeet=new adminkitapiadesi();
            kitapiadeet.Show();
            this.Hide();
        }

        private void btn_emanetkitaplar_Click(object sender, EventArgs e)
        {
            emanetkitaplar ek=new emanetkitaplar();
            ek.Show();
            this.Hide();
        }

        private void btn_gerigel_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalisanListele cl=new CalisanListele();
            cl.Show();
            this.Hide();
        }

        private void btn_emanetal_Click(object sender, EventArgs e)
        {
            emanetaladminicin ea=new emanetaladminicin();
            ea.Show();
            this.Hide();
        }

        private void AdminSayfasi_Load(object sender, EventArgs e)
        {

        }
    }
}
