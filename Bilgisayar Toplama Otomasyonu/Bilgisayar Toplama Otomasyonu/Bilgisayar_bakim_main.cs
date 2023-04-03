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
    public partial class Bilgisayar_bakim_main : Form
    {
        public Bilgisayar_bakim_main()
        {
            InitializeComponent();
        }

        private void Bilgisayar_bakim_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_mainButon_Click(object sender, EventArgs e)
        {
            Bakim_Toplama_ayrimi ayrimNesne = new Bakim_Toplama_ayrimi();
            ayrimNesne.Show();
            this.Hide();
        }

        private void btn_sorunBul_Click(object sender, EventArgs e)
        {
            if(cmbox_anaSorun.Text.Equals("") || cmbox_kacYil.Text.Equals("") || cmbox_nasilBasladi.Text.Equals(""))
            {
                MessageBox.Show("Lutfen Kutucukların Tamamını Doldurun","Dikkat",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
        }
    }
}
