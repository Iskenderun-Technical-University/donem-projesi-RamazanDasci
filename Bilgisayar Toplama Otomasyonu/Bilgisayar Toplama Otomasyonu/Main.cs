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
    }
}
