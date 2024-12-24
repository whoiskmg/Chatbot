namespace chatbotv1
{
    partial class hizlierisim
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
            this.btn_yemekhane = new System.Windows.Forms.Button();
            this.btn_duyuru = new System.Windows.Forms.Button();
            this.btn_kutuphane = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.Transparent;
            this.btngeri.Location = new System.Drawing.Point(436, 13);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(21, 20);
            this.btngeri.TabIndex = 13;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.Transparent;
            this.btncikis.Location = new System.Drawing.Point(497, 13);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(21, 20);
            this.btncikis.TabIndex = 12;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnmin
            // 
            this.btnmin.BackColor = System.Drawing.Color.Transparent;
            this.btnmin.Location = new System.Drawing.Point(467, 13);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(21, 20);
            this.btnmin.TabIndex = 11;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // btn_yemekhane
            // 
            this.btn_yemekhane.BackColor = System.Drawing.Color.Black;
            this.btn_yemekhane.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_yemekhane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yemekhane.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_yemekhane.Location = new System.Drawing.Point(184, 268);
            this.btn_yemekhane.Name = "btn_yemekhane";
            this.btn_yemekhane.Size = new System.Drawing.Size(176, 83);
            this.btn_yemekhane.TabIndex = 26;
            this.btn_yemekhane.Text = "Yemekhane Menüsü";
            this.btn_yemekhane.UseVisualStyleBackColor = false;
            this.btn_yemekhane.Click += new System.EventHandler(this.btn_yemekhane_Click);
            // 
            // btn_duyuru
            // 
            this.btn_duyuru.BackColor = System.Drawing.Color.Black;
            this.btn_duyuru.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_duyuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_duyuru.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_duyuru.Location = new System.Drawing.Point(184, 365);
            this.btn_duyuru.Name = "btn_duyuru";
            this.btn_duyuru.Size = new System.Drawing.Size(176, 83);
            this.btn_duyuru.TabIndex = 25;
            this.btn_duyuru.Text = "Duyuru ve Haberler";
            this.btn_duyuru.UseVisualStyleBackColor = false;
            this.btn_duyuru.Click += new System.EventHandler(this.btn_duyuru_Click);
            // 
            // btn_kutuphane
            // 
            this.btn_kutuphane.BackColor = System.Drawing.Color.Black;
            this.btn_kutuphane.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kutuphane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kutuphane.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_kutuphane.Location = new System.Drawing.Point(184, 172);
            this.btn_kutuphane.Name = "btn_kutuphane";
            this.btn_kutuphane.Size = new System.Drawing.Size(176, 83);
            this.btn_kutuphane.TabIndex = 24;
            this.btn_kutuphane.Text = "Kütüphane Bilgileri";
            this.btn_kutuphane.UseVisualStyleBackColor = false;
            this.btn_kutuphane.Click += new System.EventHandler(this.btn_kutuphane_Click);
            // 
            // hizlierisim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::chatbotv1.Properties.Resources.hizlierisim;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(530, 560);
            this.Controls.Add(this.btn_yemekhane);
            this.Controls.Add(this.btn_duyuru);
            this.Controls.Add(this.btn_kutuphane);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "hizlierisim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hizlierisim";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btngeri;
        private System.Windows.Forms.Panel btncikis;
        private System.Windows.Forms.Panel btnmin;
        private System.Windows.Forms.Button btn_yemekhane;
        private System.Windows.Forms.Button btn_duyuru;
        private System.Windows.Forms.Button btn_kutuphane;
    }
}