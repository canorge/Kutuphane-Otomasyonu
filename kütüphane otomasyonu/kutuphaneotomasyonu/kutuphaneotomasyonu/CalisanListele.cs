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
    public partial class CalisanListele : Form
    {
        SqlConnection baglanti = new SqlConnection("data source=CANORGE\\SQLEXPRESS; initial catalog=kutuphane; Integrated Security=True");
        public CalisanListele()
        {
            InitializeComponent();
        }

        private void CalisanListele_Load(object sender, EventArgs e)
        {
            // Sayfa yüklendiğinde datagridviewe çalışanların listelenmesi
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select id,ad,soyad,email,telno,cinsiyet from kisi where yetki='admin'", baglanti);
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource=dt;
        }

        private void button1_Click(object sender, EventArgs e)
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
