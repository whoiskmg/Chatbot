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
    public partial class iletisim : Form
    {
        public iletisim()
        {
            InitializeComponent();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iletisim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Close();
        }

        private void btn_danisman_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Danışman Bilgileri:\n\nAd Soyad: Erdem Yücesan\nE-posta: e.yucesan@iku.edu.tr\nTelefon: +90 123 456 78 90", "Danışman Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_personel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İdari Personel İletişim Bilgileri:\n\nAd Soyad: Ayşe Demir\nGörev: Öğrenci İşleri Sorumlusu\nE-posta: ayse.demir@iku.edu.tr\nTelefon: +90 123 456 78 90", "İdari Personel İletişim", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_talep_Click(object sender, EventArgs e)
        {
            talepvesikayetform talepvesikayetform = new talepvesikayetform();
            talepvesikayetform.Show();
            this.Close();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
