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
    public partial class kayitislemleri : Form
    {
        public kayitislemleri()
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

        private void kayitislemleri_Load(object sender, EventArgs e)
        {

        }

        private void btn_derskayit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ders kayıt işlemleri sona ermiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_kayityenile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu döneme kaydınız bulunmaktadır! (04.09.2024 - 02.02.2025)", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_kayitsorgula_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıt Durumu : (04.09.2024 - 02.02.2025)", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
