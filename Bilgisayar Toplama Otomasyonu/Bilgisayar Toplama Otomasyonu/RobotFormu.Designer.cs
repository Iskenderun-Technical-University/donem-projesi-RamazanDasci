namespace Bilgisayar_Toplama_Otomasyonu
{
    partial class RobotFormu
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
            this.cmbox_islemci = new System.Windows.Forms.ComboBox();
            this.cmbox_anakart = new System.Windows.Forms.ComboBox();
            this.cmbox_ram = new System.Windows.Forms.ComboBox();
            this.cmbox_seskarti = new System.Windows.Forms.ComboBox();
            this.cmbox_sivisogutucu = new System.Windows.Forms.ComboBox();
            this.cmbox_monitor = new System.Windows.Forms.ComboBox();
            this.cmbox_ekrankarti = new System.Windows.Forms.ComboBox();
            this.cmbox_kasa = new System.Windows.Forms.ComboBox();
            this.btn_toplaMain = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picture_islemci = new System.Windows.Forms.PictureBox();
            this.picture_ekrankarti = new System.Windows.Forms.PictureBox();
            this.picture_kasa = new System.Windows.Forms.PictureBox();
            this.picture_seskarti = new System.Windows.Forms.PictureBox();
            this.picture_monitor = new System.Windows.Forms.PictureBox();
            this.picture_anakart = new System.Windows.Forms.PictureBox();
            this.picture_ram = new System.Windows.Forms.PictureBox();
            this.picture_sivisogutucu = new System.Windows.Forms.PictureBox();
            this.lbl_uyari = new System.Windows.Forms.Label();
            this.btn_robotKayit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbox_rbgController = new System.Windows.Forms.ComboBox();
            this.cmbox_rgbFan = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_islemci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ekrankarti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_kasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_seskarti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_monitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_anakart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_sivisogutucu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbox_islemci
            // 
            this.cmbox_islemci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbox_islemci.FormattingEnabled = true;
            this.cmbox_islemci.Location = new System.Drawing.Point(148, 48);
            this.cmbox_islemci.Name = "cmbox_islemci";
            this.cmbox_islemci.Size = new System.Drawing.Size(685, 28);
            this.cmbox_islemci.TabIndex = 0;
            this.cmbox_islemci.SelectedIndexChanged += new System.EventHandler(this.cmbox_islemci_SelectedIndexChanged);
            // 
            // cmbox_anakart
            // 
            this.cmbox_anakart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbox_anakart.FormattingEnabled = true;
            this.cmbox_anakart.Location = new System.Drawing.Point(148, 136);
            this.cmbox_anakart.Name = "cmbox_anakart";
            this.cmbox_anakart.Size = new System.Drawing.Size(685, 28);
            this.cmbox_anakart.TabIndex = 0;
            // 
            // cmbox_ram
            // 
            this.cmbox_ram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbox_ram.FormattingEnabled = true;
            this.cmbox_ram.Location = new System.Drawing.Point(148, 224);
            this.cmbox_ram.Name = "cmbox_ram";
            this.cmbox_ram.Size = new System.Drawing.Size(685, 28);
            this.cmbox_ram.TabIndex = 0;
            // 
            // cmbox_seskarti
            // 
            this.cmbox_seskarti.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbox_seskarti.Enabled = false;
            this.cmbox_seskarti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbox_seskarti.FormattingEnabled = true;
            this.cmbox_seskarti.Location = new System.Drawing.Point(148, 400);
            this.cmbox_seskarti.Name = "cmbox_seskarti";
            this.cmbox_seskarti.Size = new System.Drawing.Size(685, 28);
            this.cmbox_seskarti.TabIndex = 0;
            this.cmbox_seskarti.Text = "Sisteminize Ses Kartı Tanımlanmamıştır";
            // 
            // cmbox_sivisogutucu
            // 
            this.cmbox_sivisogutucu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbox_sivisogutucu.Enabled = false;
            this.cmbox_sivisogutucu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbox_sivisogutucu.FormattingEnabled = true;
            this.cmbox_sivisogutucu.Location = new System.Drawing.Point(148, 488);
            this.cmbox_sivisogutucu.Name = "cmbox_sivisogutucu";
            this.cmbox_sivisogutucu.Size = new System.Drawing.Size(685, 28);
            this.cmbox_sivisogutucu.TabIndex = 0;
            this.cmbox_sivisogutucu.Text = "Sisteminize Sıvı Soğutucu Tanımlanmamıştır";
            // 
            // cmbox_monitor
            // 
            this.cmbox_monitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbox_monitor.FormattingEnabled = true;
            this.cmbox_monitor.Location = new System.Drawing.Point(148, 576);
            this.cmbox_monitor.Name = "cmbox_monitor";
            this.cmbox_monitor.Size = new System.Drawing.Size(685, 28);
            this.cmbox_monitor.TabIndex = 0;
            // 
            // cmbox_ekrankarti
            // 
            this.cmbox_ekrankarti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbox_ekrankarti.FormattingEnabled = true;
            this.cmbox_ekrankarti.Location = new System.Drawing.Point(148, 312);
            this.cmbox_ekrankarti.Name = "cmbox_ekrankarti";
            this.cmbox_ekrankarti.Size = new System.Drawing.Size(685, 28);
            this.cmbox_ekrankarti.TabIndex = 0;
            this.cmbox_ekrankarti.SelectedIndexChanged += new System.EventHandler(this.cmbox_ekrankarti_SelectedIndexChanged);
            // 
            // cmbox_kasa
            // 
            this.cmbox_kasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbox_kasa.FormattingEnabled = true;
            this.cmbox_kasa.Location = new System.Drawing.Point(148, 664);
            this.cmbox_kasa.Name = "cmbox_kasa";
            this.cmbox_kasa.Size = new System.Drawing.Size(685, 28);
            this.cmbox_kasa.TabIndex = 0;
            // 
            // btn_toplaMain
            // 
            this.btn_toplaMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_toplaMain.Location = new System.Drawing.Point(1029, 716);
            this.btn_toplaMain.Name = "btn_toplaMain";
            this.btn_toplaMain.Size = new System.Drawing.Size(270, 57);
            this.btn_toplaMain.TabIndex = 2;
            this.btn_toplaMain.Text = "Seçeneklere Geri Dön";
            this.btn_toplaMain.UseVisualStyleBackColor = true;
            this.btn_toplaMain.Click += new System.EventHandler(this.btn_toplaMain_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picture_islemci);
            this.groupBox1.Controls.Add(this.cmbox_islemci);
            this.groupBox1.Controls.Add(this.picture_ekrankarti);
            this.groupBox1.Controls.Add(this.cmbox_seskarti);
            this.groupBox1.Controls.Add(this.picture_kasa);
            this.groupBox1.Controls.Add(this.picture_seskarti);
            this.groupBox1.Controls.Add(this.picture_monitor);
            this.groupBox1.Controls.Add(this.cmbox_anakart);
            this.groupBox1.Controls.Add(this.cmbox_ekrankarti);
            this.groupBox1.Controls.Add(this.cmbox_sivisogutucu);
            this.groupBox1.Controls.Add(this.cmbox_kasa);
            this.groupBox1.Controls.Add(this.picture_anakart);
            this.groupBox1.Controls.Add(this.picture_ram);
            this.groupBox1.Controls.Add(this.picture_sivisogutucu);
            this.groupBox1.Controls.Add(this.cmbox_monitor);
            this.groupBox1.Controls.Add(this.cmbox_ram);
            this.groupBox1.Location = new System.Drawing.Point(40, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(877, 730);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgisayarını Topla";
            // 
            // picture_islemci
            // 
            this.picture_islemci.Image = global::Bilgisayar_Toplama_Otomasyonu.Properties.Resources.cpu;
            this.picture_islemci.Location = new System.Drawing.Point(40, 35);
            this.picture_islemci.Name = "picture_islemci";
            this.picture_islemci.Size = new System.Drawing.Size(76, 55);
            this.picture_islemci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_islemci.TabIndex = 1;
            this.picture_islemci.TabStop = false;
            // 
            // picture_ekrankarti
            // 
            this.picture_ekrankarti.Image = global::Bilgisayar_Toplama_Otomasyonu.Properties.Resources.gpu;
            this.picture_ekrankarti.Location = new System.Drawing.Point(40, 293);
            this.picture_ekrankarti.Name = "picture_ekrankarti";
            this.picture_ekrankarti.Size = new System.Drawing.Size(76, 66);
            this.picture_ekrankarti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_ekrankarti.TabIndex = 1;
            this.picture_ekrankarti.TabStop = false;
            // 
            // picture_kasa
            // 
            this.picture_kasa.Image = global::Bilgisayar_Toplama_Otomasyonu.Properties.Resources.computer_case;
            this.picture_kasa.Location = new System.Drawing.Point(40, 642);
            this.picture_kasa.Name = "picture_kasa";
            this.picture_kasa.Size = new System.Drawing.Size(76, 73);
            this.picture_kasa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_kasa.TabIndex = 1;
            this.picture_kasa.TabStop = false;
            // 
            // picture_seskarti
            // 
            this.picture_seskarti.Image = global::Bilgisayar_Toplama_Otomasyonu.Properties.Resources.sound_card;
            this.picture_seskarti.Location = new System.Drawing.Point(40, 380);
            this.picture_seskarti.Name = "picture_seskarti";
            this.picture_seskarti.Size = new System.Drawing.Size(76, 68);
            this.picture_seskarti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_seskarti.TabIndex = 1;
            this.picture_seskarti.TabStop = false;
            // 
            // picture_monitor
            // 
            this.picture_monitor.Image = global::Bilgisayar_Toplama_Otomasyonu.Properties.Resources.tv;
            this.picture_monitor.Location = new System.Drawing.Point(40, 558);
            this.picture_monitor.Name = "picture_monitor";
            this.picture_monitor.Size = new System.Drawing.Size(76, 64);
            this.picture_monitor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_monitor.TabIndex = 1;
            this.picture_monitor.TabStop = false;
            // 
            // picture_anakart
            // 
            this.picture_anakart.Image = global::Bilgisayar_Toplama_Otomasyonu.Properties.Resources.motherboard;
            this.picture_anakart.Location = new System.Drawing.Point(40, 116);
            this.picture_anakart.Name = "picture_anakart";
            this.picture_anakart.Size = new System.Drawing.Size(76, 69);
            this.picture_anakart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_anakart.TabIndex = 1;
            this.picture_anakart.TabStop = false;
            // 
            // picture_ram
            // 
            this.picture_ram.Image = global::Bilgisayar_Toplama_Otomasyonu.Properties.Resources.ram_memory;
            this.picture_ram.Location = new System.Drawing.Point(40, 206);
            this.picture_ram.Name = "picture_ram";
            this.picture_ram.Size = new System.Drawing.Size(76, 65);
            this.picture_ram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_ram.TabIndex = 1;
            this.picture_ram.TabStop = false;
            // 
            // picture_sivisogutucu
            // 
            this.picture_sivisogutucu.Image = global::Bilgisayar_Toplama_Otomasyonu.Properties.Resources.water_cooler;
            this.picture_sivisogutucu.Location = new System.Drawing.Point(40, 468);
            this.picture_sivisogutucu.Name = "picture_sivisogutucu";
            this.picture_sivisogutucu.Size = new System.Drawing.Size(76, 68);
            this.picture_sivisogutucu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_sivisogutucu.TabIndex = 1;
            this.picture_sivisogutucu.TabStop = false;
            // 
            // lbl_uyari
            // 
            this.lbl_uyari.AutoSize = true;
            this.lbl_uyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_uyari.ForeColor = System.Drawing.Color.Olive;
            this.lbl_uyari.Location = new System.Drawing.Point(39, 48);
            this.lbl_uyari.Name = "lbl_uyari";
            this.lbl_uyari.Size = new System.Drawing.Size(324, 20);
            this.lbl_uyari.TabIndex = 4;
            this.lbl_uyari.Text = "Bilgisayarın Durumu Burada Görünecek";
            // 
            // btn_robotKayit
            // 
            this.btn_robotKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_robotKayit.Location = new System.Drawing.Point(1029, 637);
            this.btn_robotKayit.Name = "btn_robotKayit";
            this.btn_robotKayit.Size = new System.Drawing.Size(270, 57);
            this.btn_robotKayit.TabIndex = 5;
            this.btn_robotKayit.Text = "Bilgisayarı Kaydet";
            this.btn_robotKayit.UseVisualStyleBackColor = true;
            this.btn_robotKayit.Click += new System.EventHandler(this.btn_robotKayit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_uyari);
            this.groupBox2.Location = new System.Drawing.Point(951, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 126);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilgisayar Sağlığı";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbox_rbgController);
            this.groupBox3.Controls.Add(this.cmbox_rgbFan);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(951, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(412, 242);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RGB Köşesi";
            // 
            // cmbox_rbgController
            // 
            this.cmbox_rbgController.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbox_rbgController.FormattingEnabled = true;
            this.cmbox_rbgController.Items.AddRange(new object[] {
            "Corsair Lighting Node Pro",
            "Thermaltake Pacific Lumi Plus LED Strip Control Pack",
            "Cooler Master MasterFan ARGB/PWM Hub",
            "NZXT Hue 2 RGB Lighting Kit",
            "Phanteks RGB LED Strip Combo Set."});
            this.cmbox_rbgController.Location = new System.Drawing.Point(118, 160);
            this.cmbox_rbgController.Name = "cmbox_rbgController";
            this.cmbox_rbgController.Size = new System.Drawing.Size(261, 28);
            this.cmbox_rbgController.TabIndex = 1;
            // 
            // cmbox_rgbFan
            // 
            this.cmbox_rgbFan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbox_rgbFan.FormattingEnabled = true;
            this.cmbox_rgbFan.Items.AddRange(new object[] {
            "Elgato LL120 RGB",
            "Corsair LL120 RGB",
            "Thermaltake Riing Trio 12 RGB",
            "Cooler Master MasterFan MF120R ARGB",
            "NZXT AER RGB 2",
            "Deepcool RF120M RGB",
            "Silverstone AP124-ARGB",
            "be quiet! Silent Wings 3 RGB",
            "Phanteks SK120 RGB",
            "Lian Li Bora Digital"});
            this.cmbox_rgbFan.Location = new System.Drawing.Point(118, 54);
            this.cmbox_rgbFan.Name = "cmbox_rgbFan";
            this.cmbox_rgbFan.Size = new System.Drawing.Size(261, 28);
            this.cmbox_rgbFan.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Bilgisayar_Toplama_Otomasyonu.Properties.Resources.light_control;
            this.pictureBox2.Location = new System.Drawing.Point(25, 138);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bilgisayar_Toplama_Otomasyonu.Properties.Resources.cooler;
            this.pictureBox1.Location = new System.Drawing.Point(25, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RobotFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1384, 805);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_robotKayit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_toplaMain);
            this.Name = "RobotFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RobotFormu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RobotFormu_FormClosed);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_islemci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ekrankarti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_kasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_seskarti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_monitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_anakart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_sivisogutucu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox cmbox_ekrankarti;
        public System.Windows.Forms.PictureBox picture_ekrankarti;
        public System.Windows.Forms.ComboBox cmbox_kasa;
        public System.Windows.Forms.PictureBox picture_kasa;
        public System.Windows.Forms.ComboBox cmbox_islemci;
        public System.Windows.Forms.PictureBox picture_islemci;
        public System.Windows.Forms.ComboBox cmbox_anakart;
        public System.Windows.Forms.PictureBox picture_anakart;
        public System.Windows.Forms.ComboBox cmbox_ram;
        public System.Windows.Forms.PictureBox picture_ram;
        public System.Windows.Forms.ComboBox cmbox_seskarti;
        public System.Windows.Forms.PictureBox picture_seskarti;
        public System.Windows.Forms.ComboBox cmbox_sivisogutucu;
        public System.Windows.Forms.PictureBox picture_sivisogutucu;
        public System.Windows.Forms.ComboBox cmbox_monitor;
        public System.Windows.Forms.PictureBox picture_monitor;
        private System.Windows.Forms.Button btn_toplaMain;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lbl_uyari;
        private System.Windows.Forms.Button btn_robotKayit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ComboBox cmbox_rbgController;
        public System.Windows.Forms.ComboBox cmbox_rgbFan;
    }
}