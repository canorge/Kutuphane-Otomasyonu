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
    public partial class UyeSayfasi : Form
    {
       
        public UyeSayfasi()
        {
            InitializeComponent();
        }
        // gerekli sayfalara yönlendirmeler
        public void kitapgoster()
        {
            KitapListele kl = new KitapListele();
            kl.Show();
            this.Hide();
        }

        private void btn_kitaplar_Click(object sender, EventArgs e)
        {
            KitapListele kl=new KitapListele();
            kl.Show(); 
            this.Hide();
        }

        private void btn_emanetal_Click(object sender, EventArgs e)
        {
            KitapEmanetAl kitapemanet=new KitapEmanetAl();
            kitapemanet.Show();
            this.Hide();
        }

        private void btn_iadeet_Click(object sender, EventArgs e)
        {
            kitapiadeet kitapiadeet=new kitapiadeet();
            kitapiadeet.Show();
            this.Hide();
        }

        private void btn_gerigel_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void UyeSayfasi_Load(object sender, EventArgs e)
        {

        }
    }
}
