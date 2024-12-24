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
    public partial class odemeislemleri : Form
    {
        public odemeislemleri()
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

        private void btn_burs_Click(object sender, EventArgs e)
        {
            string bursBilgileri = "Burs Durumu Bilgileri:\n\n" +
                                         "Burs Türü: Başarı Bursu\n" +
                                         "Başlangıç Tarihi: 15.09.2023\n" +
                                         "Bitiş Tarihi: 30.06.2024\n" +
                                         "Durum: Aktif\n" +
                                         "Açıklama: Bu burs akademik başarıya göre verilmektedir.";

            MessageBox.Show(bursBilgileri,
                            "Burs Durumu",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btn_borc_Click(object sender, EventArgs e)
        {
            string borcBilgileri = "Üniversite Borç Bilgileri:\n\n" +
                           "Toplam Borç: 2,450.00 TL\n" +
                           "Son Ödeme Tarihi: 15.01.2024\n" +
                           "Durum: Ödeme Bekleniyor\n" +
                           "Açıklama: Borcunuzu belirtilen tarihe kadar ödeyiniz.";

            MessageBox.Show(borcBilgileri,
                            "Borç Sorgulama",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btn_harc_Click(object sender, EventArgs e)
        {
            string harcBilgileri = "Harç Ödeme Bilgileri:\n\n" +
                           "Toplam Harç: 3,750.00 TL\n" +
                           "Son Ödeme Tarihi: 01.02.2024\n" +
                           "Durum: Ödeme Bekleniyor\n" +
                           "Açıklama: Harcınızı belirtilen tarihe kadar ödeyiniz.";

            MessageBox.Show(harcBilgileri,
                            "Harç Ödeme Bilgisi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
