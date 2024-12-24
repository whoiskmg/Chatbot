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
    public partial class transkriptbelgesi : Form
    {
        public transkriptbelgesi()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btncikis_Paint(object sender, PaintEventArgs e)
        {

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
            belgeler belgeler = new belgeler();
            belgeler.Show();
            this.Close();
        }

        private void btn_indir_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) // PictureBox'ta bir resim olup olmadığını kontrol edin
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp"; // Kaydedilecek dosya türlerini belirtin
                saveFileDialog.Title = "Resmi Farklı Kaydet";
                saveFileDialog.FileName = "resim"; // Varsayılan dosya adı

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Resmi seçilen formatta kaydet
                        string extension = System.IO.Path.GetExtension(saveFileDialog.FileName).ToLower();
                        System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Jpeg;

                        if (extension == ".png")
                        {
                            format = System.Drawing.Imaging.ImageFormat.Png;
                        }
                        else if (extension == ".bmp")
                        {
                            format = System.Drawing.Imaging.ImageFormat.Bmp;
                        }

                        pictureBox1.Image.Save(saveFileDialog.FileName, format); // Resmi kaydet
                        MessageBox.Show("Resim başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Kaydedilecek bir resim yok!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void transkriptbelgesi_Load(object sender, EventArgs e)
        {

        }
    }
}
