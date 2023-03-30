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
            this.btn_bakim_yap = new System.Windows.Forms.Button();
            this.btn_bilgisayar_topla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_bakim_yap
            // 
            this.btn_bakim_yap.Location = new System.Drawing.Point(454, 200);
            this.btn_bakim_yap.Name = "btn_bakim_yap";
            this.btn_bakim_yap.Size = new System.Drawing.Size(165, 75);
            this.btn_bakim_yap.TabIndex = 1;
            this.btn_bakim_yap.Text = "Bilgisayarımdaki Sorunu Bulmak İstiyorum";
            this.btn_bakim_yap.UseVisualStyleBackColor = true;
            this.btn_bakim_yap.Click += new System.EventHandler(this.btn_bakim_yap_Click);
            // 
            // btn_bilgisayar_topla
            // 
            this.btn_bilgisayar_topla.Location = new System.Drawing.Point(174, 200);
            this.btn_bilgisayar_topla.Name = "btn_bilgisayar_topla";
            this.btn_bilgisayar_topla.Size = new System.Drawing.Size(155, 75);
            this.btn_bilgisayar_topla.TabIndex = 2;
            this.btn_bilgisayar_topla.Text = "Bilgisayar toplamak istiyorum";
            this.btn_bilgisayar_topla.UseVisualStyleBackColor = true;
            this.btn_bilgisayar_topla.Click += new System.EventHandler(this.btn_bilgisayar_topla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bilgisayar Toplama ve Bakım Robotuna Hoş Geldiniz";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 475);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_bilgisayar_topla);
            this.Controls.Add(this.btn_bakim_yap);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_bakim_yap;
        private System.Windows.Forms.Button btn_bilgisayar_topla;
        private System.Windows.Forms.Label label1;
    }
}

