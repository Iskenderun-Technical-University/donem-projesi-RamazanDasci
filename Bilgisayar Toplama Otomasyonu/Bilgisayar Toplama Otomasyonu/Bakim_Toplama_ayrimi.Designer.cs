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
            this.btn_bilgisayar_topla = new System.Windows.Forms.Button();
            this.btn_bakim_yap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(302, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bilgisayar Toplama ve Bakım Robotuna Hoş Geldiniz";
            // 
            // btn_bilgisayar_topla
            // 
            this.btn_bilgisayar_topla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bilgisayar_topla.Location = new System.Drawing.Point(217, 328);
            this.btn_bilgisayar_topla.Name = "btn_bilgisayar_topla";
            this.btn_bilgisayar_topla.Size = new System.Drawing.Size(204, 94);
            this.btn_bilgisayar_topla.TabIndex = 5;
            this.btn_bilgisayar_topla.Text = "Bilgisayar toplamak istiyorum";
            this.btn_bilgisayar_topla.UseVisualStyleBackColor = true;
            this.btn_bilgisayar_topla.Click += new System.EventHandler(this.btn_bilgisayar_topla_Click);
            // 
            // btn_bakim_yap
            // 
            this.btn_bakim_yap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bakim_yap.Location = new System.Drawing.Point(563, 328);
            this.btn_bakim_yap.Name = "btn_bakim_yap";
            this.btn_bakim_yap.Size = new System.Drawing.Size(204, 94);
            this.btn_bakim_yap.TabIndex = 4;
            this.btn_bakim_yap.Text = "Bilgisayarımdaki Sorunu Bulmak İstiyorum";
            this.btn_bakim_yap.UseVisualStyleBackColor = true;
            this.btn_bakim_yap.Click += new System.EventHandler(this.btn_bakim_yap_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(21, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 61);
            this.button1.TabIndex = 7;
            this.button1.Text = "Login Ekranı";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bakim_Toplama_ayrimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_bilgisayar_topla);
            this.Controls.Add(this.btn_bakim_yap);
            this.Name = "Bakim_Toplama_ayrimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bakim_Toplama_ayrimi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Bakim_Toplama_ayrimi_FormClosed);
            this.Load += new System.EventHandler(this.Bakim_Toplama_ayrimi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_bilgisayar_topla;
        private System.Windows.Forms.Button btn_bakim_yap;
        private System.Windows.Forms.Button button1;
    }
}