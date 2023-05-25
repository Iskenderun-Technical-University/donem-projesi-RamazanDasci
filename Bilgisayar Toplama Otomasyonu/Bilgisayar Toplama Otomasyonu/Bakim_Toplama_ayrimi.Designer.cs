namespace Bilgisayar_Toplama_Otomasyonu
{
    partial class Bakim_Toplama_ayrimi
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_hesapInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_topla = new Bilgisayar_Toplama_Otomasyonu.RJButton();
            this.btn_sorunBul = new Bilgisayar_Toplama_Otomasyonu.RJButton();
            this.btn_login = new Bilgisayar_Toplama_Otomasyonu.RJButton();
            this.btn_kapat = new Bilgisayar_Toplama_Otomasyonu.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(227, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bilgisayar Toplama ve Bakım Robotuna Hoş Geldiniz";
            // 
            // lbl_hesapInfo
            // 
            this.lbl_hesapInfo.AutoSize = true;
            this.lbl_hesapInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hesapInfo.Location = new System.Drawing.Point(64, 29);
            this.lbl_hesapInfo.Name = "lbl_hesapInfo";
            this.lbl_hesapInfo.Size = new System.Drawing.Size(195, 16);
            this.lbl_hesapInfo.TabIndex = 8;
            this.lbl_hesapInfo.Text = "Hesap Bilgileri İçin Giriş Yapınız";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bilgisayar_Toplama_Otomasyonu.Properties.Resources.USER_PHOTO;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_topla
            // 
            this.btn_topla.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_topla.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.btn_topla.BorderColor = System.Drawing.Color.Black;
            this.btn_topla.BorderRadius = 15;
            this.btn_topla.BorderSize = 1;
            this.btn_topla.FlatAppearance.BorderSize = 0;
            this.btn_topla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_topla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_topla.ForeColor = System.Drawing.Color.Black;
            this.btn_topla.Location = new System.Drawing.Point(232, 348);
            this.btn_topla.Name = "btn_topla";
            this.btn_topla.Size = new System.Drawing.Size(204, 94);
            this.btn_topla.TabIndex = 10;
            this.btn_topla.Text = "Bilgisayar Toplamak İstiyorum";
            this.btn_topla.TextColor = System.Drawing.Color.Black;
            this.btn_topla.UseVisualStyleBackColor = false;
            this.btn_topla.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // btn_sorunBul
            // 
            this.btn_sorunBul.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_sorunBul.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.btn_sorunBul.BorderColor = System.Drawing.Color.Black;
            this.btn_sorunBul.BorderRadius = 15;
            this.btn_sorunBul.BorderSize = 1;
            this.btn_sorunBul.FlatAppearance.BorderSize = 0;
            this.btn_sorunBul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sorunBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sorunBul.ForeColor = System.Drawing.Color.Black;
            this.btn_sorunBul.Location = new System.Drawing.Point(600, 348);
            this.btn_sorunBul.Name = "btn_sorunBul";
            this.btn_sorunBul.Size = new System.Drawing.Size(204, 94);
            this.btn_sorunBul.TabIndex = 11;
            this.btn_sorunBul.Text = "Bilgisayarımdaki Sorunu Bulmak İstiyorum";
            this.btn_sorunBul.TextColor = System.Drawing.Color.Black;
            this.btn_sorunBul.UseVisualStyleBackColor = false;
            this.btn_sorunBul.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_login.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.btn_login.BorderColor = System.Drawing.Color.Black;
            this.btn_login.BorderRadius = 15;
            this.btn_login.BorderSize = 1;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_login.ForeColor = System.Drawing.Color.Black;
            this.btn_login.Location = new System.Drawing.Point(12, 495);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(64, 55);
            this.btn_login.TabIndex = 12;
            this.btn_login.Text = "Login Ekranı";
            this.btn_login.TextColor = System.Drawing.Color.Black;
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_kapat.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.btn_kapat.BorderColor = System.Drawing.Color.Black;
            this.btn_kapat.BorderRadius = 15;
            this.btn_kapat.BorderSize = 1;
            this.btn_kapat.FlatAppearance.BorderSize = 0;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kapat.ForeColor = System.Drawing.Color.Black;
            this.btn_kapat.Location = new System.Drawing.Point(925, 9);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(52, 36);
            this.btn_kapat.TabIndex = 13;
            this.btn_kapat.Text = "Kapat";
            this.btn_kapat.TextColor = System.Drawing.Color.Black;
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.rjButton4_Click);
            // 
            // Bakim_Toplama_ayrimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 562);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_sorunBul);
            this.Controls.Add(this.btn_topla);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_hesapInfo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bakim_Toplama_ayrimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bakim_Toplama_ayrimi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Bakim_Toplama_ayrimi_FormClosed);
            this.Load += new System.EventHandler(this.Bakim_Toplama_ayrimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lbl_hesapInfo;
        private RJButton btn_topla;
        private RJButton btn_sorunBul;
        private RJButton btn_login;
        private RJButton btn_kapat;
    }
}