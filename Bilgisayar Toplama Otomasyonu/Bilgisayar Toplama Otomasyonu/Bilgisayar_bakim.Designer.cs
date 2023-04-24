namespace Bilgisayar_Toplama_Otomasyonu
{
    partial class Bilgisayar_bakim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bilgisayar_bakim));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxt_anaProblem = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtxt_nasilBasladi = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtxt_pcYas = new System.Windows.Forms.RichTextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxt_anaProblem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 587);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgisayarınızın Ana Problemi";
            // 
            // rtxt_anaProblem
            // 
            this.rtxt_anaProblem.Location = new System.Drawing.Point(30, 46);
            this.rtxt_anaProblem.Name = "rtxt_anaProblem";
            this.rtxt_anaProblem.Size = new System.Drawing.Size(499, 517);
            this.rtxt_anaProblem.TabIndex = 0;
            this.rtxt_anaProblem.Text = resources.GetString("rtxt_anaProblem.Text");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtxt_nasilBasladi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(574, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 286);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sorun Nasıl Başladı";
            // 
            // rtxt_nasilBasladi
            // 
            this.rtxt_nasilBasladi.Location = new System.Drawing.Point(23, 46);
            this.rtxt_nasilBasladi.Name = "rtxt_nasilBasladi";
            this.rtxt_nasilBasladi.Size = new System.Drawing.Size(563, 234);
            this.rtxt_nasilBasladi.TabIndex = 0;
            this.rtxt_nasilBasladi.Text = resources.GetString("rtxt_nasilBasladi.Text");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtxt_pcYas);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(574, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(603, 295);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bilgisayarın Yaşı";
            // 
            // rtxt_pcYas
            // 
            this.rtxt_pcYas.Location = new System.Drawing.Point(23, 51);
            this.rtxt_pcYas.Name = "rtxt_pcYas";
            this.rtxt_pcYas.Size = new System.Drawing.Size(563, 209);
            this.rtxt_pcYas.TabIndex = 0;
            this.rtxt_pcYas.Text = resources.GetString("rtxt_pcYas.Text");
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_back.Location = new System.Drawing.Point(1052, 618);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(108, 38);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Geri Dön";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Bilgisayar_bakim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 668);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bilgisayar_bakim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgisayar_bakim";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.RichTextBox rtxt_anaProblem;
        public System.Windows.Forms.RichTextBox rtxt_nasilBasladi;
        public System.Windows.Forms.RichTextBox rtxt_pcYas;
        private System.Windows.Forms.Button btn_back;
    }
}