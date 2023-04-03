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
            System.Windows.Forms.Button btn_mainButon;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbox_anaSorun = new System.Windows.Forms.ComboBox();
            this.cmbox_nasilBasladi = new System.Windows.Forms.ComboBox();
            this.cmbox_kacYil = new System.Windows.Forms.ComboBox();
            this.btn_sorunBul = new System.Windows.Forms.Button();
            btn_mainButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_mainButon
            // 
            btn_mainButon.Location = new System.Drawing.Point(727, 8);
            btn_mainButon.Name = "btn_mainButon";
            btn_mainButon.Size = new System.Drawing.Size(61, 43);
            btn_mainButon.TabIndex = 1;
            btn_mainButon.Text = "Ana Sayfa";
            btn_mainButon.UseVisualStyleBackColor = true;
            btn_mainButon.Click += new System.EventHandler(this.btn_mainButon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(280, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilgisayar Bakım Ana Sayfa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(233, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "UYARI !!! Öncelikle Burada Yapılacak İşemler Tehlikeli \r\nOlabilir, Belirli Seviye" +
    "de Elektronik Bilgisi Olmayanlar \r\nLütfen En Yakın Teknik Servise Başvurunuz\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(74, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bilgisayarınızdaki Sorun Nedir?\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(74, 232);
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
            this.btn_sorunBul.Location = new System.Drawing.Point(367, 363);
            this.btn_sorunBul.Name = "btn_sorunBul";
            this.btn_sorunBul.Size = new System.Drawing.Size(121, 46);
            this.btn_sorunBul.TabIndex = 5;
            this.btn_sorunBul.Text = "Sorunumu Bul";
            this.btn_sorunBul.UseVisualStyleBackColor = true;
            this.btn_sorunBul.Click += new System.EventHandler(this.btn_sorunBul_Click);
            // 
            // Bilgisayar_bakim_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sorunBul);
            this.Controls.Add(this.cmbox_kacYil);
            this.Controls.Add(this.cmbox_nasilBasladi);
            this.Controls.Add(this.cmbox_anaSorun);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(btn_mainButon);
            this.Controls.Add(this.label1);
            this.Name = "Bilgisayar_bakim_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgisayar_bakim_main";
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
        private System.Windows.Forms.Button btn_sorunBul;
    }
}