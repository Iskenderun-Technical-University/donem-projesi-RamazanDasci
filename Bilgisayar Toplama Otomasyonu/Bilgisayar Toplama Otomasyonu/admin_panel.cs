using Bilgisayar_Toplama_Otomasyonu.Sql_degiskenleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgisayar_Toplama_Otomasyonu
{
    public partial class admin_panel : Form
    {
        public admin_panel()
        {
            InitializeComponent();
        }

        private void admin_panel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void kayitgetir (String gelecekSutun, String tabloIsim, DataGridView dataGrid)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT " + gelecekSutun + " FROM "+ tabloIsim, Sql_operation.sqlConnect);
            Sql_operation.checkedConnection(Sql_operation.sqlConnect);

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataSet dt = new DataSet();
            adapter.Fill(dt);
            dataGrid.AutoGenerateColumns = true;
            dataGrid.DataSource = dt.Tables[0];
        }

        private void btn_anakart_kayitGetir_Click(object sender, EventArgs e)
        {
            kayitgetir("Anakart_ad", "table_anakart", dataG_anakart);
        }


        private void btn_islemci_kayitGetir_Click(object sender, EventArgs e)
        {
            kayitgetir("islemci_ad", "table_islemci", dataG_islemci);
        }

        private void btn_ram_kayitGetir_Click(object sender, EventArgs e)
        {
            kayitgetir("Ram_name", "tableRam", dataG_ram);
        }

        private void btn_ekranK_kayitGetir_Click(object sender, EventArgs e)
        {
            kayitgetir("EkranK_ad", "tableEkranK", dataG_ekranK);
        }

        private void btn_monitor_kayitGetir_Click(object sender, EventArgs e)
        {
            kayitgetir("monitor_isim", "table_monitor", dataG_monitor);

        }

        private void btn_kasa_kayitGetir_Click(object sender, EventArgs e)
        {
            kayitgetir("Kasa_ad", "table_kasa", dataG_kasa);
        }

        private void btn_sesK_kayitGetir_Click(object sender, EventArgs e)
        {
            kayitgetir("Seskarti_ad" , "tableSesK", dataG_sesK);
        }

        private void btn_siviS_kayitGetir_Click(object sender, EventArgs e)
        {
            kayitgetir("Cooling_ad", "tableCooling", dataG_siviS);
        }

        private void btn_kullanicilar_kayitGetir_Click(object sender, EventArgs e)
        {
            kayitgetir("*", "KullaniciGirisBilgileri", dataG_kullanicilar);
        }

        private void btn_kullaniciB_kayitGetir_Click(object sender, EventArgs e)
        {
            kayitgetir("*", "table_kullaniciSistem", dataG_kullaniciB);
        }







    }
}


