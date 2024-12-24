namespace chatbotv1
{
    partial class odemeislemleri
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
            this.btn_borc = new System.Windows.Forms.Button();
            this.btn_burs = new System.Windows.Forms.Button();
            this.btn_harc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.Transparent;
            this.btngeri.Location = new System.Drawing.Point(436, 13);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(21, 20);
            this.btngeri.TabIndex = 16;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.Transparent;
            this.btncikis.Location = new System.Drawing.Point(497, 13);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(21, 20);
            this.btncikis.TabIndex = 15;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnmin
            // 
            this.btnmin.BackColor = System.Drawing.Color.Transparent;
            this.btnmin.Location = new System.Drawing.Point(467, 13);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(21, 20);
            this.btnmin.TabIndex = 14;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // btn_borc
            // 
            this.btn_borc.BackColor = System.Drawing.Color.Black;
            this.btn_borc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_borc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_borc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_borc.Location = new System.Drawing.Point(178, 272);
            this.btn_borc.Name = "btn_borc";
            this.btn_borc.Size = new System.Drawing.Size(176, 83);
            this.btn_borc.TabIndex = 29;
            this.btn_borc.Text = "Borç Sorgulama";
            this.btn_borc.UseVisualStyleBackColor = false;
            this.btn_borc.Click += new System.EventHandler(this.btn_borc_Click);
            // 
            // btn_burs
            // 
            this.btn_burs.BackColor = System.Drawing.Color.Black;
            this.btn_burs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_burs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_burs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_burs.Location = new System.Drawing.Point(178, 369);
            this.btn_burs.Name = "btn_burs";
            this.btn_burs.Size = new System.Drawing.Size(176, 83);
            this.btn_burs.TabIndex = 28;
            this.btn_burs.Text = "Burs Durumu";
            this.btn_burs.UseVisualStyleBackColor = false;
            this.btn_burs.Click += new System.EventHandler(this.btn_burs_Click);
            // 
            // btn_harc
            // 
            this.btn_harc.BackColor = System.Drawing.Color.Black;
            this.btn_harc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_harc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_harc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_harc.Location = new System.Drawing.Point(178, 176);
            this.btn_harc.Name = "btn_harc";
            this.btn_harc.Size = new System.Drawing.Size(176, 83);
            this.btn_harc.TabIndex = 27;
            this.btn_harc.Text = "Harç Ödeme";
            this.btn_harc.UseVisualStyleBackColor = false;
            this.btn_harc.Click += new System.EventHandler(this.btn_harc_Click);
            // 
            // odemeislemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::chatbotv1.Properties.Resources.odemeislemleri;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(530, 560);
            this.Controls.Add(this.btn_borc);
            this.Controls.Add(this.btn_burs);
            this.Controls.Add(this.btn_harc);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "odemeislemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "odemeislemleri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btngeri;
        private System.Windows.Forms.Panel btncikis;
        private System.Windows.Forms.Panel btnmin;
        private System.Windows.Forms.Button btn_borc;
        private System.Windows.Forms.Button btn_burs;
        private System.Windows.Forms.Button btn_harc;
    }
}