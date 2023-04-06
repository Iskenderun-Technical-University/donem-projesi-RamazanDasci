namespace Bilgisayar_Toplama_Otomasyonu
{
    partial class ToplananPcGetir
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datagrid_toplananPC = new System.Windows.Forms.DataGridView();
            this.txt_eposta = new System.Windows.Forms.TextBox();
            this.txt_anakart = new System.Windows.Forms.TextBox();
            this.txt_islemci = new System.Windows.Forms.TextBox();
            this.txt_ekranK = new System.Windows.Forms.TextBox();
            this.txt_power = new System.Windows.Forms.TextBox();
            this.txt_kasa = new System.Windows.Forms.TextBox();
            this.txt_sound = new System.Windows.Forms.TextBox();
            this.txt_ram = new System.Windows.Forms.TextBox();
            this.txt_sivi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_kayitEkle = new System.Windows.Forms.Button();
            this.btn_paneliKapat = new System.Windows.Forms.Button();
            this.btn_kayitSil = new System.Windows.Forms.Button();
            this.btn_kutulariTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_toplananPC)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_toplananPC
            // 
            this.datagrid_toplananPC.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_toplananPC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_toplananPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_toplananPC.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_toplananPC.Location = new System.Drawing.Point(12, 12);
            this.datagrid_toplananPC.Name = "datagrid_toplananPC";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_toplananPC.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid_toplananPC.Size = new System.Drawing.Size(1339, 464);
            this.datagrid_toplananPC.TabIndex = 0;
            this.datagrid_toplananPC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.datagrid_toplananPC_MouseClick);
            this.datagrid_toplananPC.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.datagrid_toplananPC_MouseDoubleClick);
            // 
            // txt_eposta
            // 
            this.txt_eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_eposta.Location = new System.Drawing.Point(193, 496);
            this.txt_eposta.Name = "txt_eposta";
            this.txt_eposta.ReadOnly = true;
            this.txt_eposta.Size = new System.Drawing.Size(246, 26);
            this.txt_eposta.TabIndex = 2;
            this.txt_eposta.Text = "eposta";
            // 
            // txt_anakart
            // 
            this.txt_anakart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_anakart.Location = new System.Drawing.Point(193, 528);
            this.txt_anakart.Name = "txt_anakart";
            this.txt_anakart.Size = new System.Drawing.Size(246, 26);
            this.txt_anakart.TabIndex = 2;
            // 
            // txt_islemci
            // 
            this.txt_islemci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_islemci.Location = new System.Drawing.Point(193, 561);
            this.txt_islemci.Name = "txt_islemci";
            this.txt_islemci.Size = new System.Drawing.Size(246, 26);
            this.txt_islemci.TabIndex = 2;
            // 
            // txt_ekranK
            // 
            this.txt_ekranK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ekranK.Location = new System.Drawing.Point(193, 594);
            this.txt_ekranK.Name = "txt_ekranK";
            this.txt_ekranK.Size = new System.Drawing.Size(246, 26);
            this.txt_ekranK.TabIndex = 2;
            // 
            // txt_power
            // 
            this.txt_power.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_power.Location = new System.Drawing.Point(652, 528);
            this.txt_power.Name = "txt_power";
            this.txt_power.Size = new System.Drawing.Size(246, 26);
            this.txt_power.TabIndex = 2;
            // 
            // txt_kasa
            // 
            this.txt_kasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kasa.Location = new System.Drawing.Point(652, 561);
            this.txt_kasa.Name = "txt_kasa";
            this.txt_kasa.Size = new System.Drawing.Size(246, 26);
            this.txt_kasa.TabIndex = 2;
            // 
            // txt_sound
            // 
            this.txt_sound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sound.Location = new System.Drawing.Point(652, 594);
            this.txt_sound.Name = "txt_sound";
            this.txt_sound.Size = new System.Drawing.Size(246, 26);
            this.txt_sound.TabIndex = 2;
            // 
            // txt_ram
            // 
            this.txt_ram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ram.Location = new System.Drawing.Point(652, 496);
            this.txt_ram.Name = "txt_ram";
            this.txt_ram.Size = new System.Drawing.Size(246, 26);
            this.txt_ram.TabIndex = 2;
            // 
            // txt_sivi
            // 
            this.txt_sivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sivi.Location = new System.Drawing.Point(1085, 490);
            this.txt_sivi.Name = "txt_sivi";
            this.txt_sivi.Size = new System.Drawing.Size(246, 26);
            this.txt_sivi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı E-posta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 528);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bilgisayar Anakart";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 560);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bilgisayar İşlemci";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(460, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bilgisayar Ram";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(460, 531);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bilgisayar Güç Kaynağı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(31, 595);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Bilgisayar Ekran Kartı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(460, 567);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Bilgisayar Kasa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(460, 597);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Bilgisayar Ses Kartı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(920, 493);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "İşelmci Sıvı Soğutucu";
            // 
            // btn_kayitEkle
            // 
            this.btn_kayitEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitEkle.Location = new System.Drawing.Point(1142, 531);
            this.btn_kayitEkle.Name = "btn_kayitEkle";
            this.btn_kayitEkle.Size = new System.Drawing.Size(189, 37);
            this.btn_kayitEkle.TabIndex = 4;
            this.btn_kayitEkle.Text = "Kendi Kaydını Ekle";
            this.btn_kayitEkle.UseVisualStyleBackColor = true;
            this.btn_kayitEkle.Click += new System.EventHandler(this.btn_kayitEkle_Click);
            // 
            // btn_paneliKapat
            // 
            this.btn_paneliKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_paneliKapat.Location = new System.Drawing.Point(1142, 574);
            this.btn_paneliKapat.Name = "btn_paneliKapat";
            this.btn_paneliKapat.Size = new System.Drawing.Size(189, 37);
            this.btn_paneliKapat.TabIndex = 4;
            this.btn_paneliKapat.Text = "Paneli Kapat";
            this.btn_paneliKapat.UseVisualStyleBackColor = true;
            this.btn_paneliKapat.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_kayitSil
            // 
            this.btn_kayitSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitSil.Location = new System.Drawing.Point(933, 531);
            this.btn_kayitSil.Name = "btn_kayitSil";
            this.btn_kayitSil.Size = new System.Drawing.Size(189, 37);
            this.btn_kayitSil.TabIndex = 4;
            this.btn_kayitSil.Text = "Kaydı Sil";
            this.btn_kayitSil.UseVisualStyleBackColor = true;
            this.btn_kayitSil.Click += new System.EventHandler(this.btn_kayitSil_Click);
            // 
            // btn_kutulariTemizle
            // 
            this.btn_kutulariTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kutulariTemizle.Location = new System.Drawing.Point(933, 574);
            this.btn_kutulariTemizle.Name = "btn_kutulariTemizle";
            this.btn_kutulariTemizle.Size = new System.Drawing.Size(189, 37);
            this.btn_kutulariTemizle.TabIndex = 4;
            this.btn_kutulariTemizle.Text = "Kutucukları Temizle";
            this.btn_kutulariTemizle.UseVisualStyleBackColor = true;
            this.btn_kutulariTemizle.Click += new System.EventHandler(this.btn_kutulariTemizle_Click);
            // 
            // ToplananPcGetir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 632);
            this.Controls.Add(this.btn_paneliKapat);
            this.Controls.Add(this.btn_kutulariTemizle);
            this.Controls.Add(this.btn_kayitSil);
            this.Controls.Add(this.btn_kayitEkle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sivi);
            this.Controls.Add(this.txt_sound);
            this.Controls.Add(this.txt_ekranK);
            this.Controls.Add(this.txt_kasa);
            this.Controls.Add(this.txt_islemci);
            this.Controls.Add(this.txt_ram);
            this.Controls.Add(this.txt_power);
            this.Controls.Add(this.txt_anakart);
            this.Controls.Add(this.txt_eposta);
            this.Controls.Add(this.datagrid_toplananPC);
            this.Name = "ToplananPcGetir";
            this.Text = "ToplananPcGetir";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ToplananPcGetir_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_toplananPC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView datagrid_toplananPC;
        private System.Windows.Forms.TextBox txt_anakart;
        private System.Windows.Forms.TextBox txt_islemci;
        private System.Windows.Forms.TextBox txt_ekranK;
        private System.Windows.Forms.TextBox txt_power;
        private System.Windows.Forms.TextBox txt_kasa;
        private System.Windows.Forms.TextBox txt_sound;
        private System.Windows.Forms.TextBox txt_ram;
        private System.Windows.Forms.TextBox txt_sivi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_kayitEkle;
        private System.Windows.Forms.Button btn_paneliKapat;
        private System.Windows.Forms.Button btn_kayitSil;
        private System.Windows.Forms.Button btn_kutulariTemizle;
        public System.Windows.Forms.TextBox txt_eposta;
    }
}