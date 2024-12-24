namespace chatbotv1
{
    partial class talepvesikayetform
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_gonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.Transparent;
            this.btngeri.Location = new System.Drawing.Point(441, 13);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(21, 20);
            this.btngeri.TabIndex = 46;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.Transparent;
            this.btncikis.Location = new System.Drawing.Point(502, 13);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(21, 20);
            this.btncikis.TabIndex = 45;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnmin
            // 
            this.btnmin.BackColor = System.Drawing.Color.Transparent;
            this.btnmin.Location = new System.Drawing.Point(472, 13);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(21, 20);
            this.btnmin.TabIndex = 44;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.richTextBox1.Location = new System.Drawing.Point(120, 108);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(298, 185);
            this.richTextBox1.TabIndex = 47;
            this.richTextBox1.Text = "";
            // 
            // btn_gonder
            // 
            this.btn_gonder.BackColor = System.Drawing.Color.Black;
            this.btn_gonder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_gonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gonder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_gonder.Location = new System.Drawing.Point(120, 309);
            this.btn_gonder.Name = "btn_gonder";
            this.btn_gonder.Size = new System.Drawing.Size(298, 59);
            this.btn_gonder.TabIndex = 48;
            this.btn_gonder.Text = "Talep Gönder";
            this.btn_gonder.UseVisualStyleBackColor = false;
            this.btn_gonder.Click += new System.EventHandler(this.btn_gonder_Click);
            // 
            // talepvesikayetform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::chatbotv1.Properties.Resources.talepvesikayetform;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(540, 560);
            this.Controls.Add(this.btn_gonder);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "talepvesikayetform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "talepvesikayetform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btngeri;
        private System.Windows.Forms.Panel btncikis;
        private System.Windows.Forms.Panel btnmin;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_gonder;
    }
}