namespace Bilgisayar_Toplama_Otomasyonu
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_userEposta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lnklbl_sifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_admin = new Bilgisayar_Toplama_Otomasyonu.RJButton();
            this.btn_misafir = new Bilgisayar_Toplama_Otomasyonu.RJButton();
            this.btn_login = new Bilgisayar_Toplama_Otomasyonu.RJButton();
            this.btn_exit = new Bilgisayar_Toplama_Otomasyonu.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(546, 251);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(158, 29);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Parolayı Göster";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_password.Location = new System.Drawing.Point(306, 251);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(197, 26);
            this.txt_password.TabIndex = 1;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // txt_userEposta
            // 
            this.txt_userEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_userEposta.Location = new System.Drawing.Point(306, 197);
            this.txt_userEposta.Name = "txt_userEposta";
            this.txt_userEposta.Size = new System.Drawing.Size(197, 26);
            this.txt_userEposta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(194, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "E Posta ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(194, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Parola";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(407, 425);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(99, 15);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Hemen Kaydolun";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(300, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hesabınız Yok Mu? ";
            // 
            // lnklbl_sifremiUnuttum
            // 
            this.lnklbl_sifremiUnuttum.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lnklbl_sifremiUnuttum.AutoSize = true;
            this.lnklbl_sifremiUnuttum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lnklbl_sifremiUnuttum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnklbl_sifremiUnuttum.ForeColor = System.Drawing.Color.White;
            this.lnklbl_sifremiUnuttum.LinkColor = System.Drawing.Color.Transparent;
            this.lnklbl_sifremiUnuttum.Location = new System.Drawing.Point(359, 283);
            this.lnklbl_sifremiUnuttum.Name = "lnklbl_sifremiUnuttum";
            this.lnklbl_sifremiUnuttum.Size = new System.Drawing.Size(95, 15);
            this.lnklbl_sifremiUnuttum.TabIndex = 10;
            this.lnklbl_sifremiUnuttum.TabStop = true;
            this.lnklbl_sifremiUnuttum.Text = "Şifremi Unuttum";
            this.lnklbl_sifremiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_sifremiUnuttum_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Bilgisayar_Toplama_Otomasyonu.Properties.Resources.Başlıkcfrdhgdrghdrhdhsız_1;
            this.pictureBox2.Location = new System.Drawing.Point(-22, -153);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(816, 656);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = global::Bilgisayar_Toplama_Otomasyonu.Properties.Resources.USER_PHOTO1;
            this.pictureBox1.Location = new System.Drawing.Point(334, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btn_admin
            // 
            this.btn_admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_admin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_admin.BorderColor = System.Drawing.Color.White;
            this.btn_admin.BorderRadius = 15;
            this.btn_admin.BorderSize = 2;
            this.btn_admin.FlatAppearance.BorderSize = 0;
            this.btn_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_admin.ForeColor = System.Drawing.Color.White;
            this.btn_admin.Location = new System.Drawing.Point(113, 332);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(162, 59);
            this.btn_admin.TabIndex = 17;
            this.btn_admin.Text = "Admin Girişi";
            this.btn_admin.TextColor = System.Drawing.Color.White;
            this.btn_admin.UseVisualStyleBackColor = false;
            this.btn_admin.Click += new System.EventHandler(this.rjButton4_Click);
            // 
            // btn_misafir
            // 
            this.btn_misafir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_misafir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_misafir.BorderColor = System.Drawing.Color.White;
            this.btn_misafir.BorderRadius = 15;
            this.btn_misafir.BorderSize = 2;
            this.btn_misafir.FlatAppearance.BorderSize = 0;
            this.btn_misafir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_misafir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_misafir.ForeColor = System.Drawing.Color.White;
            this.btn_misafir.Location = new System.Drawing.Point(523, 332);
            this.btn_misafir.Name = "btn_misafir";
            this.btn_misafir.Size = new System.Drawing.Size(162, 59);
            this.btn_misafir.TabIndex = 16;
            this.btn_misafir.Text = "Misafir Olarak Devam Et";
            this.btn_misafir.TextColor = System.Drawing.Color.White;
            this.btn_misafir.UseVisualStyleBackColor = false;
            this.btn_misafir.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_login.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_login.BorderColor = System.Drawing.Color.White;
            this.btn_login.BorderRadius = 15;
            this.btn_login.BorderSize = 2;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(318, 332);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(162, 59);
            this.btn_login.TabIndex = 15;
            this.btn_login.Text = "Giriş Yap";
            this.btn_login.TextColor = System.Drawing.Color.White;
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.rjButton2_Click_1);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(190)))));
            this.btn_exit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(190)))));
            this.btn_exit.BorderColor = System.Drawing.Color.Red;
            this.btn_exit.BorderRadius = 15;
            this.btn_exit.BorderSize = 0;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(720, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(49, 39);
            this.btn_exit.TabIndex = 14;
            this.btn_exit.Text = "Çıkış";
            this.btn_exit.TextColor = System.Drawing.Color.White;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 475);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.btn_misafir);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lnklbl_sifremiUnuttum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_userEposta);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_userEposta;
        private System.Windows.Forms.LinkLabel lnklbl_sifremiUnuttum;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RJButton btn_exit;
        private RJButton btn_login;
        private RJButton btn_misafir;
        private RJButton btn_admin;
    }
}

