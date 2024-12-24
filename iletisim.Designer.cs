namespace chatbotv1
{
    partial class iletisim
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
            this.btn_personel = new System.Windows.Forms.Button();
            this.btn_talep = new System.Windows.Forms.Button();
            this.btn_danisman = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.Transparent;
            this.btngeri.Location = new System.Drawing.Point(436, 13);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(21, 20);
            this.btngeri.TabIndex = 19;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.Transparent;
            this.btncikis.Location = new System.Drawing.Point(497, 13);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(21, 20);
            this.btncikis.TabIndex = 18;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnmin
            // 
            this.btnmin.BackColor = System.Drawing.Color.Transparent;
            this.btnmin.Location = new System.Drawing.Point(467, 13);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(21, 20);
            this.btnmin.TabIndex = 17;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // btn_personel
            // 
            this.btn_personel.BackColor = System.Drawing.Color.Black;
            this.btn_personel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_personel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_personel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_personel.Location = new System.Drawing.Point(176, 267);
            this.btn_personel.Name = "btn_personel";
            this.btn_personel.Size = new System.Drawing.Size(176, 83);
            this.btn_personel.TabIndex = 32;
            this.btn_personel.Text = "İdari Personel İletişim";
            this.btn_personel.UseVisualStyleBackColor = false;
            this.btn_personel.Click += new System.EventHandler(this.btn_personel_Click);
            // 
            // btn_talep
            // 
            this.btn_talep.BackColor = System.Drawing.Color.Black;
            this.btn_talep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_talep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_talep.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_talep.Location = new System.Drawing.Point(176, 364);
            this.btn_talep.Name = "btn_talep";
            this.btn_talep.Size = new System.Drawing.Size(176, 83);
            this.btn_talep.TabIndex = 31;
            this.btn_talep.Text = "Talep ve Şikayet";
            this.btn_talep.UseVisualStyleBackColor = false;
            this.btn_talep.Click += new System.EventHandler(this.btn_talep_Click);
            // 
            // btn_danisman
            // 
            this.btn_danisman.BackColor = System.Drawing.Color.Black;
            this.btn_danisman.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_danisman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_danisman.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_danisman.Location = new System.Drawing.Point(176, 171);
            this.btn_danisman.Name = "btn_danisman";
            this.btn_danisman.Size = new System.Drawing.Size(176, 83);
            this.btn_danisman.TabIndex = 30;
            this.btn_danisman.Text = "Danışman Bilgileri";
            this.btn_danisman.UseVisualStyleBackColor = false;
            this.btn_danisman.Click += new System.EventHandler(this.btn_danisman_Click);
            // 
            // iletisim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::chatbotv1.Properties.Resources.iletisim;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(530, 560);
            this.Controls.Add(this.btn_personel);
            this.Controls.Add(this.btn_talep);
            this.Controls.Add(this.btn_danisman);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "iletisim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iletisim";
            this.Click += new System.EventHandler(this.iletisim_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btngeri;
        private System.Windows.Forms.Panel btncikis;
        private System.Windows.Forms.Panel btnmin;
        private System.Windows.Forms.Button btn_personel;
        private System.Windows.Forms.Button btn_talep;
        private System.Windows.Forms.Button btn_danisman;
    }
}