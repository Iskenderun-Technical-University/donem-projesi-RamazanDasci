using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgisayar_Toplama_Otomasyonu
{
    public partial class Bakim_Toplama_ayrimi : Form
    {
        public Bakim_Toplama_ayrimi()
        {
            InitializeComponent();


        }
        
      

        private void Bakim_Toplama_ayrimi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Bilgisayar_topla_main formPC = new Bilgisayar_topla_main();
            formPC.Show();
            this.Hide();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            Bilgisayar_bakim_main Formbakim = new Bilgisayar_bakim_main();
            Formbakim.Show();
            this.Hide();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            if (Main.girisYapildiMi == 1)
            {

                if (MessageBox.Show("Hesaptan Çıkış Yapılacaktır Onaylıyor Musunuz", "Dikkat", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Main.girisYapildiMi = 0;
                    Bakim_Toplama_ayrimi bakim_Toplama_Ayrimi = new Bakim_Toplama_ayrimi();
                    bakim_Toplama_Ayrimi.lbl_hesapInfo.Text = "Hesap Bilgileri İçin Giriş Yapınız";

                    main.Show();
                    this.Hide();
                }
            }
            else
            {

                main.Show();
                this.Hide();

            }
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
