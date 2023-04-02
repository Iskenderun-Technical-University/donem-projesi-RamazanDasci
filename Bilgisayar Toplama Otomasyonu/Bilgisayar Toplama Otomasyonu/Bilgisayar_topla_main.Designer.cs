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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilgisayar Toplama Ana Sayfa";
            // 
            // btn_mainButton
            // 
            this.btn_mainButton.Location = new System.Drawing.Point(733, 9);
            this.btn_mainButton.Name = "btn_mainButton";
            this.btn_mainButton.Size = new System.Drawing.Size(55, 45);
            this.btn_mainButton.TabIndex = 1;
            this.btn_mainButton.Text = "Ana Sayfa";
            this.btn_mainButton.UseVisualStyleBackColor = true;
            this.btn_mainButton.Click += new System.EventHandler(this.btn_mainButton_Click);
            // 
            // Bilgisayar_topla_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}