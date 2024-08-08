using kutuphaneotomasyonu.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneotomasyonu
{
    public partial class UyeListesi : Form
    {
        SqlConnection baglanti = new SqlConnection("data source=CANORGE\\SQLEXPRESS; initial catalog=kutuphane; Integrated Security=True");
        public UyeListesi()
        {
            InitializeComponent();
        }
        public void uyegetir()
        {
            baglanti.Open();
            // kisi tablosundaki yetkisi üye olan verilerin datagridviewe yazdırılması
            List<Kisi>Kisiler=new List<Kisi>(); 
            SqlCommand cmd = new SqlCommand("select * from kisi where yetki='üye'",baglanti);
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            baglanti.Close();
                     
        }

        private void UyeListesi_Load(object sender, EventArgs e)
        {
            uyegetir();
        }

        private void btn_gerigel_Click(object sender, EventArgs e)
        {
            AdminSayfasi ad=new AdminSayfasi();
            ad.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
