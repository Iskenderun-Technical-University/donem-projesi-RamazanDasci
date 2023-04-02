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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void btn_misafirGiris_Click(object sender, EventArgs e)
        {
            Bakim_Toplama_ayrimi ayrimNesnesi = new Bakim_Toplama_ayrimi();
            ayrimNesnesi.Show();
            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                txt_password.UseSystemPasswordChar = true;
            }
            else
            {
                txt_password.UseSystemPasswordChar= false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kayit_form kayitNesnesi = new kayit_form();
            kayitNesnesi.Show();
            this.Hide();
        }
    }
}
