namespace Bilgisayar_Toplama_Otomasyonu
{
    partial class Bilgisayar_topla_main
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
            this.btn_mainButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbox_anaIstek = new System.Windows.Forms.ComboBox();
            this.btn_robotclstr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilgisayar Toplama Ana Sayfa";
            // 
            // btn_mainButton
            // 
            this.btn_mainButton.Location = new System.Drawing.Point(1268, 12);
            this.btn_mainButton.Name = "btn_mainButton";
            this.btn_mainButton.Size = new System.Drawing.Size(55, 45);
            this.btn_mainButton.TabIndex = 1;
            this.btn_mainButton.Text = "Ana Sayfa";
            this.btn_mainButton.UseVisualStyleBackColor = true;
            this.btn_mainButton.Click += new System.EventHandler(this.btn_mainButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(93, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bilgisayarı Ne Amaçla Kullanmak İstiyorsunuz ?\r\n";
            // 
            // cmbox_anaIstek
            // 
            this.cmbox_anaIstek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbox_anaIstek.FormattingEnabled = true;
            this.cmbox_anaIstek.Items.AddRange(new object[] {
            "Offis İşlerinde Kullanmak İstiyorum",
            "Eğitim İçin Kullanmak İstiyorum",
            "Oyun Amaçlı Kullanmak İstiyorum",
            "Sunucu Olarak Kullanmak İstiyorum",
            "Grafik-Render Tasarımları İçin İstiyorum"});
            this.cmbox_anaIstek.Location = new System.Drawing.Point(438, 102);
            this.cmbox_anaIstek.Name = "cmbox_anaIstek";
            this.cmbox_anaIstek.Size = new System.Drawing.Size(362, 28);
            this.cmbox_anaIstek.TabIndex = 3;
            // 
            // btn_robotclstr
            // 
            this.btn_robotclstr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_robotclstr.Location = new System.Drawing.Point(588, 706);
            this.btn_robotclstr.Name = "btn_robotclstr";
            this.btn_robotclstr.Size = new System.Drawing.Size(190, 42);
            this.btn_robotclstr.TabIndex = 4;
            this.btn_robotclstr.Text = "Bana Bilgisayar Bul";
            this.btn_robotclstr.UseVisualStyleBackColor = true;
            this.btn_robotclstr.Click += new System.EventHandler(this.btn_robotclstr_Click);
            // 
            // Bilgisayar_topla_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 832);
            this.Controls.Add(this.btn_robotclstr);
            this.Controls.Add(this.cmbox_anaIstek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_mainButton);
            this.Controls.Add(this.label1);
            this.Name = "Bilgisayar_topla_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bilgisayar_topla_main_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_mainButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbox_anaIstek;
        private System.Windows.Forms.Button btn_robotclstr;
    }
}