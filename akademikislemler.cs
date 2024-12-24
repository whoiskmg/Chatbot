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
    public partial class akademikislemler : Form
    {
        public akademikislemler()
        {
            InitializeComponent();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmin_Paint(object sender, PaintEventArgs e)
        {

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

        private void akademikislemler_Load(object sender, EventArgs e)
        {

        }

        private void btn_dersprogrami_Click(object sender, EventArgs e)
        {
            dersprogrami dersprogrami = new dersprogrami();
            dersprogrami.Show();
            this.Close();
        }

        private void btn_devamsizlik_Click(object sender, EventArgs e)
        {
            devamsizlikbilgisi devamsizlikbilgisi = new devamsizlikbilgisi();
            devamsizlikbilgisi.Show();
            this.Close();
        }

        private void btn_not_Click(object sender, EventArgs e)
        {
            notlarsayfasi notlarsayfasi = new notlarsayfasi();
            notlarsayfasi.Show();
            this.Close();
        }

        private void btn_sinavtarihi_Click(object sender, EventArgs e)
        {
            sinavsayfasi sinavsayfasi = new sinavsayfasi();
            sinavsayfasi.Show();
            this.Close();
        }
    }
}
