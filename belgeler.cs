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
    public partial class belgeler : Form
    {
        public belgeler()
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

        private void btn_transkript_Click(object sender, EventArgs e)
        {
            transkriptbelgesi transkriptbelgesi = new transkriptbelgesi();
            transkriptbelgesi.Show();
            this.Close();
        }

        private void btn_ogrencibelgesi_Click(object sender, EventArgs e)
        {
            ogrencibelgesiform ogrencibelgesiform = new ogrencibelgesiform();
            ogrencibelgesiform.Show();
            this.Close();
        }

        private void btn_mezuniyet_Click(object sender, EventArgs e)
        {
            mezuniyetbelgesiform mezuniyetbelgesiform = new mezuniyetbelgesiform();
            mezuniyetbelgesiform.Show();
            this.Close();
        }
    }
}
