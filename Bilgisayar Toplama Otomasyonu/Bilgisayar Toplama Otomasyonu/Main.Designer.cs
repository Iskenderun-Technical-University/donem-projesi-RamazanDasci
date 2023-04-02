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
            this.btn_misafirGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_misafirGiris
            // 
            this.btn_misafirGiris.Location = new System.Drawing.Point(422, 347);
            this.btn_misafirGiris.Name = "btn_misafirGiris";
            this.btn_misafirGiris.Size = new System.Drawing.Size(169, 57);
            this.btn_misafirGiris.TabIndex = 0;
            this.btn_misafirGiris.Text = "Misafir Olarak Devam Et";
            this.btn_misafirGiris.UseVisualStyleBackColor = true;
            this.btn_misafirGiris.Click += new System.EventHandler(this.btn_misafirGiris_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 475);
            this.Controls.Add(this.btn_misafirGiris);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_misafirGiris;
    }
}

