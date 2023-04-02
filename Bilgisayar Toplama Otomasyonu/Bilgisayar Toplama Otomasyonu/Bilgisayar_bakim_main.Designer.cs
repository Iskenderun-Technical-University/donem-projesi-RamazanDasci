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
            btn_mainButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilgisayar Bakım Ana Sayfa";
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
            // Bilgisayar_bakim_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}