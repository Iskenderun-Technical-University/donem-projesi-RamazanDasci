﻿using System;
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
        
        private void btn_bilgisayar_topla_Click(object sender, EventArgs e)
        {
            Bilgisayar_topla_main formPC = new Bilgisayar_topla_main();
            formPC.Show();
            this.Hide();
        }

        private void btn_bakim_yap_Click(object sender, EventArgs e)
        {
            Bilgisayar_bakim_main Formbakim = new Bilgisayar_bakim_main();
            Formbakim.Show();
            this.Hide();
        }

        private void Bakim_Toplama_ayrimi_Load(object sender, EventArgs e)
        {

        }

        private void Bakim_Toplama_ayrimi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
