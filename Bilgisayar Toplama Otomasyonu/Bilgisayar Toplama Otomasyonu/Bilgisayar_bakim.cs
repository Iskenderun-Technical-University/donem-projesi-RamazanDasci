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
    public partial class Bilgisayar_bakim : Form
    {
        public Bilgisayar_bakim()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Bilgisayar_bakim_main bilgisayar_Bakim = new Bilgisayar_bakim_main();
            this.Hide();
            bilgisayar_Bakim.Show();
        }
    }
}
