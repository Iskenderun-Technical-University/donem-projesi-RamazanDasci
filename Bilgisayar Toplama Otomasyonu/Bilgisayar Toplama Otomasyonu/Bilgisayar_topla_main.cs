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
    public partial class Bilgisayar_topla_main : Form
    {
        public Bilgisayar_topla_main()
        {
            InitializeComponent();
        }

        private void Bilgisayar_topla_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_mainButton_Click(object sender, EventArgs e)
        {
            Bakim_Toplama_ayrimi ayrimNesne= new Bakim_Toplama_ayrimi();
            ayrimNesne.Show();
            this.Hide();
        }

        private void btn_robotclstr_Click(object sender, EventArgs e)
        {
            if(cmbox_anaIstek.Text.Equals("Lütfen Bir Seçim Yapınız...") || cmbox_monitorSecim.Text.Equals("Lütfen Bir Seçim Yapınız...") || cmbox_seviyeBelirt.Text.Equals("Lütfen Bir Seçim Yapınız..."))
            {
                MessageBox.Show("Çoklu Seçimleri Lütfen Doldurunuz","Dikkat",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
            
        }

        private void btn_toplananPCgetir_Click(object sender, EventArgs e)
        {
            if(Main.girisYapildiMi==1)
            {
                //SQL BAĞLANTIIS SAĞLANACAK
            }
            else
            {
                MessageBox.Show("Bu Özelliği Kullanabilmek İçin Giriş Yapmalısınız", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
