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
    public partial class intro : Form
    {
        public intro()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            anasayfa anasayfaForm = Application.OpenForms.OfType<anasayfa>().FirstOrDefault();
            if (anasayfaForm == null)
            {
                anasayfaForm = new anasayfa();
                anasayfaForm.Show();
            }
        }
    }
}
