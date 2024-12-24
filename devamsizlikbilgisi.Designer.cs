namespace chatbotv1
{
    partial class devamsizlikbilgisi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btngeri = new System.Windows.Forms.Panel();
            this.btncikis = new System.Windows.Forms.Panel();
            this.btnmin = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_indir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.Transparent;
            this.btngeri.Location = new System.Drawing.Point(436, 13);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(21, 20);
            this.btngeri.TabIndex = 22;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            this.btngeri.Paint += new System.Windows.Forms.PaintEventHandler(this.btngeri_Paint);
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.Transparent;
            this.btncikis.Location = new System.Drawing.Point(497, 13);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(21, 20);
            this.btncikis.TabIndex = 21;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnmin
            // 
            this.btnmin.BackColor = System.Drawing.Color.Transparent;
            this.btnmin.Location = new System.Drawing.Point(467, 13);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(21, 20);
            this.btnmin.TabIndex = 20;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::chatbotv1.Properties.Resources.devamsızlıkbilgisi;
            this.pictureBox1.Location = new System.Drawing.Point(87, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btn_indir
            // 
            this.btn_indir.BackColor = System.Drawing.Color.Black;
            this.btn_indir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_indir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_indir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_indir.Location = new System.Drawing.Point(165, 446);
            this.btn_indir.Name = "btn_indir";
            this.btn_indir.Size = new System.Drawing.Size(200, 77);
            this.btn_indir.TabIndex = 24;
            this.btn_indir.Text = "Belgeyi İndir";
            this.btn_indir.UseVisualStyleBackColor = false;
            this.btn_indir.Click += new System.EventHandler(this.btn_indir_Click);
            // 
            // devamsizlikbilgisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::chatbotv1.Properties.Resources.devamsizliksayfasi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(530, 560);
            this.Controls.Add(this.btn_indir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "devamsizlikbilgisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "devamsizlikbilgisi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btngeri;
        private System.Windows.Forms.Panel btncikis;
        private System.Windows.Forms.Panel btnmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_indir;
    }
}