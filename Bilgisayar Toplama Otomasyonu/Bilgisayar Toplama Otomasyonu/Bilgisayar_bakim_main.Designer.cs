namespace Bilgisayar_Toplama_Otomasyonu
{
    partial class Bilgisayar_bakim_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bilgisayar_bakim_main));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbox_anaSorun = new System.Windows.Forms.ComboBox();
            this.cmbox_nasilBasladi = new System.Windows.Forms.ComboBox();
            this.cmbox_kacYil = new System.Windows.Forms.ComboBox();
            this.btn_sorunBul = new Bilgisayar_Toplama_Otomasyonu.RJButton();
            this.btn_anaSayfa = new Bilgisayar_Toplama_Otomasyonu.RJButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(236, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilgisayar Bakım Ana Sayfa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(49, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(719, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "UYARI !!! Öncelikle Burada Yapılacak İşemler Tehlikeli  Olabilir, Belirli Seviyed" +
    "e Elektronik Bilgisi Olmayanlar \r\nLütfen En Yakın Teknik Servise Başvurunuz\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(74, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bilgisayarınızdaki Sorun Nedir?\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(74, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sorun Nasıl Başladı?\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(74, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bilgisayarı Alalı Kaç Yıl Oldu?";
            // 
            // cmbox_anaSorun
            // 
            this.cmbox_anaSorun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbox_anaSorun.FormattingEnabled = true;
            this.cmbox_anaSorun.Items.AddRange(new object[] {
            "1- Bilgisayarım Start Almıyor",
            "2- Bilgisayarım Açılıyor Ama Görüntü Vermiyor",
            "3- Bilgisayarım Açılıyor Fakat Görüntü Bozuk",
            "4- Bilgisayarım Olur Olmadık Yerde Kapanıyor",
            "5- Mavi Ekran Hatası Alıyorum",
            "6- Bilgisayarımın Bazı Kompanentleri Doğru Çalışmıyor",
            "7- Bilgisayarımın USB Çıkışları Çalışmıyor",
            "8- Bilgisayarım İnternete Bağlanmıyor",
            "9- Bilgisayarım Çok Yavaşladı",
            "10- Bilgisayarımın Ses Çıkışları Çalışmıyor",
            "11- Sorunum Burada Yok"});
            this.cmbox_anaSorun.Location = new System.Drawing.Point(319, 175);
            this.cmbox_anaSorun.Name = "cmbox_anaSorun";
            this.cmbox_anaSorun.Size = new System.Drawing.Size(400, 28);
            this.cmbox_anaSorun.TabIndex = 4;
            // 
            // cmbox_nasilBasladi
            // 
            this.cmbox_nasilBasladi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbox_nasilBasladi.FormattingEnabled = true;
            this.cmbox_nasilBasladi.Items.AddRange(new object[] {
            "1- Bir Anda Olmaya Başladı",
            "2- Zaman İçerisinde Ara Ara Oluyor",
            "3- Normal Bir Şekilde Açtığımda Sorun İle Karşılaştım",
            "4- Fiziksel Hasar Sonucu",
            "5- Cevabım Burada Yok"});
            this.cmbox_nasilBasladi.Location = new System.Drawing.Point(319, 224);
            this.cmbox_nasilBasladi.Name = "cmbox_nasilBasladi";
            this.cmbox_nasilBasladi.Size = new System.Drawing.Size(400, 28);
            this.cmbox_nasilBasladi.TabIndex = 4;
            // 
            // cmbox_kacYil
            // 
            this.cmbox_kacYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbox_kacYil.FormattingEnabled = true;
            this.cmbox_kacYil.Items.AddRange(new object[] {
            "1- (0-2) Yıl",
            "2- (2-4) Yıl",
            "3- (4-6) Yıl",
            "4- (6-8) Yıl",
            "5- (>8)  Yıl"});
            this.cmbox_kacYil.Location = new System.Drawing.Point(319, 274);
            this.cmbox_kacYil.Name = "cmbox_kacYil";
            this.cmbox_kacYil.Size = new System.Drawing.Size(400, 28);
            this.cmbox_kacYil.TabIndex = 4;
            // 
            // btn_sorunBul
            // 
            this.btn_sorunBul.BackColor = System.Drawing.Color.LightYellow;
            this.btn_sorunBul.BackgroundColor = System.Drawing.Color.LightYellow;
            this.btn_sorunBul.BorderColor = System.Drawing.Color.Black;
            this.btn_sorunBul.BorderRadius = 15;
            this.btn_sorunBul.BorderSize = 1;
            this.btn_sorunBul.FlatAppearance.BorderSize = 0;
            this.btn_sorunBul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sorunBul.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sorunBul.ForeColor = System.Drawing.Color.Black;
            this.btn_sorunBul.Location = new System.Drawing.Point(353, 392);
            this.btn_sorunBul.Name = "btn_sorunBul";
            this.btn_sorunBul.Size = new System.Drawing.Size(144, 46);
            this.btn_sorunBul.TabIndex = 6;
            this.btn_sorunBul.Text = "Sorunumu Bul";
            this.btn_sorunBul.TextColor = System.Drawing.Color.Black;
            this.btn_sorunBul.UseVisualStyleBackColor = false;
            this.btn_sorunBul.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // btn_anaSayfa
            // 
            this.btn_anaSayfa.BackColor = System.Drawing.Color.LightYellow;
            this.btn_anaSayfa.BackgroundColor = System.Drawing.Color.LightYellow;
            this.btn_anaSayfa.BorderColor = System.Drawing.Color.Black;
            this.btn_anaSayfa.BorderRadius = 12;
            this.btn_anaSayfa.BorderSize = 1;
            this.btn_anaSayfa.FlatAppearance.BorderSize = 0;
            this.btn_anaSayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anaSayfa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_anaSayfa.ForeColor = System.Drawing.Color.Black;
            this.btn_anaSayfa.Location = new System.Drawing.Point(721, 12);
            this.btn_anaSayfa.Name = "btn_anaSayfa";
            this.btn_anaSayfa.Size = new System.Drawing.Size(67, 52);
            this.btn_anaSayfa.TabIndex = 7;
            this.btn_anaSayfa.Text = "Ana Sayfa";
            this.btn_anaSayfa.TextColor = System.Drawing.Color.Black;
            this.btn_anaSayfa.UseVisualStyleBackColor = false;
            this.btn_anaSayfa.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // Bilgisayar_bakim_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btn_anaSayfa);
            this.Controls.Add(this.btn_sorunBul);
            this.Controls.Add(this.cmbox_kacYil);
            this.Controls.Add(this.cmbox_nasilBasladi);
            this.Controls.Add(this.cmbox_anaSorun);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bilgisayar_bakim_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgisayarına Bakım Yap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bilgisayar_bakim_main_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbox_anaSorun;
        private System.Windows.Forms.ComboBox cmbox_nasilBasladi;
        private System.Windows.Forms.ComboBox cmbox_kacYil;
        private RJButton btn_sorunBul;
        private RJButton btn_anaSayfa;
    }
}