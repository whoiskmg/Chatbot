using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatbotv1
{
    public partial class hizlierisim : Form
    {
        public hizlierisim()
        {
            InitializeComponent();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Close();
        }

        private void btn_kutuphane_Click(object sender, EventArgs e)
        {
            kutuphanebilgileriform kutuphanebilgileriform = new kutuphanebilgileriform();
            kutuphanebilgileriform.Show();
            this.Close();
        }

        private void btn_yemekhane_Click(object sender, EventArgs e)
        {
            yemekhanebilgileriform yemekhanebilgileriform = new yemekhanebilgileriform();
            yemekhanebilgileriform.Show();
            this.Close();
        }

        private void btn_duyuru_Click(object sender, EventArgs e)
        {
            duyuruvehaberlerform duyuruvehaberlerform = new duyuruvehaberlerform();
            duyuruvehaberlerform.Show();
            this.Close();
        }
    }
}
