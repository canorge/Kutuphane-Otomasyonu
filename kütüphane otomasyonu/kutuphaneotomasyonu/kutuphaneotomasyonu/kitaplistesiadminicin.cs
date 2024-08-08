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
    public partial class kitaplistesiadminicin : Form
    {
        SqlConnection baglanti = new SqlConnection("data source=CANORGE\\SQLEXPRESS; initial catalog=kutuphane; Integrated Security=True");
        public kitaplistesiadminicin()
        {
            InitializeComponent();
        }

        private void kitaplistesiadminicin_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            // Sayfa yüklendiğinde kitap tablosundaki bütün kitapların datagridviewe yüklenmesi
            SqlCommand cmd = new SqlCommand("select * from kitap", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void btn_gerigel_Click(object sender, EventArgs e)
        {
            AdminSayfasi ad = new AdminSayfasi();
            ad.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
