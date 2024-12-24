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
    public partial class talepvesikayetform : Form
    {
        public talepvesikayetform()
        {
            InitializeComponent();
        }

        private void btn_gonder_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                MessageBox.Show("Öneri Veya Şikayetiniz Bildirilmiştir. Teşekkür ederiz!",
                                "Bilgilendirme",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen bir öneri veya şikayet metni giriniz!",
                                "Uyarı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
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
            iletisim iletisim = new iletisim();
            iletisim.Show();
            this.Close();
        }
    }
}
