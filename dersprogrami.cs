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
    public partial class dersprogrami : Form
    {
        public dersprogrami()
        {
            InitializeComponent();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            akademikislemler akademikislemler = new akademikislemler();
            akademikislemler.Show();
            this.Close();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
