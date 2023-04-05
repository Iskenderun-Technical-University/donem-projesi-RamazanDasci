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
            this.datagrid_toplananPC = new System.Windows.Forms.DataGridView();
            this.btn_panelkapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_toplananPC)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_toplananPC
            // 
            this.datagrid_toplananPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_toplananPC.Location = new System.Drawing.Point(137, 23);
            this.datagrid_toplananPC.Name = "datagrid_toplananPC";
            this.datagrid_toplananPC.Size = new System.Drawing.Size(1209, 402);
            this.datagrid_toplananPC.TabIndex = 0;
            // 
            // btn_panelkapat
            // 
            this.btn_panelkapat.Location = new System.Drawing.Point(677, 670);
            this.btn_panelkapat.Name = "btn_panelkapat";
            this.btn_panelkapat.Size = new System.Drawing.Size(98, 38);
            this.btn_panelkapat.TabIndex = 1;
            this.btn_panelkapat.Text = "Paneli Kapat";
            this.btn_panelkapat.UseVisualStyleBackColor = true;
            this.btn_panelkapat.Click += new System.EventHandler(this.btn_panelkapat_Click);
            // 
            // ToplananPcGetir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 720);
            this.Controls.Add(this.btn_panelkapat);
            this.Controls.Add(this.datagrid_toplananPC);
            this.Name = "ToplananPcGetir";
            this.Text = "ToplananPcGetir";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_toplananPC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_panelkapat;
        public System.Windows.Forms.DataGridView datagrid_toplananPC;
    }
}