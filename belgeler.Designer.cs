namespace chatbotv1
{
    partial class belgeler
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
            this.btn_ogrencibelgesi = new System.Windows.Forms.Button();
            this.btn_mezuniyet = new System.Windows.Forms.Button();
            this.btn_transkript = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.Transparent;
            this.btngeri.Location = new System.Drawing.Point(436, 13);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(21, 20);
            this.btngeri.TabIndex = 10;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.Transparent;
            this.btncikis.Location = new System.Drawing.Point(497, 13);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(21, 20);
            this.btncikis.TabIndex = 9;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnmin
            // 
            this.btnmin.BackColor = System.Drawing.Color.Transparent;
            this.btnmin.Location = new System.Drawing.Point(467, 13);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(21, 20);
            this.btnmin.TabIndex = 8;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // btn_ogrencibelgesi
            // 
            this.btn_ogrencibelgesi.BackColor = System.Drawing.Color.Black;
            this.btn_ogrencibelgesi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ogrencibelgesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ogrencibelgesi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ogrencibelgesi.Location = new System.Drawing.Point(180, 267);
            this.btn_ogrencibelgesi.Name = "btn_ogrencibelgesi";
            this.btn_ogrencibelgesi.Size = new System.Drawing.Size(176, 83);
            this.btn_ogrencibelgesi.TabIndex = 23;
            this.btn_ogrencibelgesi.Text = "Öğrenci Belgesi";
            this.btn_ogrencibelgesi.UseVisualStyleBackColor = false;
            this.btn_ogrencibelgesi.Click += new System.EventHandler(this.btn_ogrencibelgesi_Click);
            // 
            // btn_mezuniyet
            // 
            this.btn_mezuniyet.BackColor = System.Drawing.Color.Black;
            this.btn_mezuniyet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_mezuniyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_mezuniyet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_mezuniyet.Location = new System.Drawing.Point(180, 364);
            this.btn_mezuniyet.Name = "btn_mezuniyet";
            this.btn_mezuniyet.Size = new System.Drawing.Size(176, 83);
            this.btn_mezuniyet.TabIndex = 22;
            this.btn_mezuniyet.Text = "Mezuniyet Belgesi";
            this.btn_mezuniyet.UseVisualStyleBackColor = false;
            this.btn_mezuniyet.Click += new System.EventHandler(this.btn_mezuniyet_Click);
            // 
            // btn_transkript
            // 
            this.btn_transkript.BackColor = System.Drawing.Color.Black;
            this.btn_transkript.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_transkript.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_transkript.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_transkript.Location = new System.Drawing.Point(180, 171);
            this.btn_transkript.Name = "btn_transkript";
            this.btn_transkript.Size = new System.Drawing.Size(176, 83);
            this.btn_transkript.TabIndex = 21;
            this.btn_transkript.Text = "Transkript Belgesi";
            this.btn_transkript.UseVisualStyleBackColor = false;
            this.btn_transkript.Click += new System.EventHandler(this.btn_transkript_Click);
            // 
            // belgeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::chatbotv1.Properties.Resources.belgeler;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(530, 560);
            this.Controls.Add(this.btn_ogrencibelgesi);
            this.Controls.Add(this.btn_mezuniyet);
            this.Controls.Add(this.btn_transkript);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "belgeler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "belgeler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btngeri;
        private System.Windows.Forms.Panel btncikis;
        private System.Windows.Forms.Panel btnmin;
        private System.Windows.Forms.Button btn_ogrencibelgesi;
        private System.Windows.Forms.Button btn_mezuniyet;
        private System.Windows.Forms.Button btn_transkript;
    }
}