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
            kayitgetir("Anakart_ad", "table_anakart", dataG_anakart);
            kayitgetir("islemci_ad", "table_islemci", dataG_islemci);
            kayitgetir("Ram_name", "tableRam", dataG_ram);
            kayitgetir("EkranK_ad", "tableEkranK", dataG_ekranK);
            kayitgetir("Kasa_ad", "table_kasa", dataG_kasa);
            kayitgetir("Seskarti_ad", "tableSesK", dataG_sesK);
            kayitgetir("Cooling_ad", "tableCooling", dataG_siviS);

        }
        public String geciciTasiyici = null;

        private void admin_panel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void kayitgetir (String gelecekSutun, String tabloIsim, DataGridView dataGrid)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT " + gelecekSutun + " FROM " + tabloIsim, Sql_operation.sqlConnect);
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




        public void kayitEkle (TextBox textBox, String tabloIsim, String name)
        {
            if (textBox.Text.Equals(""))
                MessageBox.Show("Kutucuğu Doldurun");
            else
            {
                SqlCommand CommandRegister = new SqlCommand("INSERT INTO " + tabloIsim + " (" + name + ") VALUES (@pDegerler)", Sql_operation.sqlConnect);
                Sql_operation.checkedConnection(Sql_operation.sqlConnect);
                CommandRegister.Parameters.AddWithValue("@pDegerler", textBox.Text);

                CommandRegister.ExecuteNonQuery();
                textBox.Text = "";
                MessageBox.Show("Başarıyla Eklendi");
            }
        }

        private void btn_anakart_kayitEkle_Click(object sender, EventArgs e)
        {

            kayitEkle(txt_anakartIsim, "table_anakart", "Anakart_ad");
        }

        private void btn_islemci_kayitEkle_Click(object sender, EventArgs e)
        {
            kayitEkle(txt_islemciIsim, "table_islemci", "islemci_ad");
        }

        private void btn_ram_kayitEkle_Click(object sender, EventArgs e)
        {
            kayitEkle(txt_ramIsim, "tableRam", "Ram_name");
        }

        private void btn_ekranK_kayitEkle_Click(object sender, EventArgs e)
        {
            kayitEkle(txt_ekranKIsım, "tableEkranK", "EkranK_ad");
        }

        private void btn_monitor_kayitEkle_Click(object sender, EventArgs e)
        {
            kayitEkle(txt_monitorIsım, "table_monitor", "monitor_isim");
        }

        private void btn_kasa_kayitEkle_Click(object sender, EventArgs e)
        {
            kayitEkle(txt_kasaIsim, "table_kasa", "Kasa_ad");
        }

        private void btn_sesK_kayitEkle_Click(object sender, EventArgs e)
        {
            kayitEkle(txt_sesKIsim, "tableSesK", "Seskarti_ad");
        }

        private void btn_siviS_kayitEkle_Click(object sender, EventArgs e)
        {
            kayitEkle(txt_coolingIsim, "tableCooling", "Cooling_ad");
        }


        public void kayitSil (String urunIsim, String tabloIsim )
        {
            if (geciciTasiyici.Equals(null))
            {
                MessageBox.Show("Silme İşleminden Önce Bir Satır Seçiniz...", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand SilKomut = new SqlCommand("Delete From " + tabloIsim + " where " + urunIsim + " = @sistemId", Sql_operation.sqlConnect);
                Sql_operation.checkedConnection(Sql_operation.sqlConnect);

                SilKomut.Parameters.AddWithValue("@sistemId", geciciTasiyici);
                SilKomut.ExecuteNonQuery();
                geciciTasiyici = null;
                MessageBox.Show("Başarıyla Silindi");
            }
        }

        public void dataSecim(DataGridView dataGridView)
        {
            int secilen = dataGridView.SelectedCells[0].RowIndex;
            geciciTasiyici = dataGridView.Rows[secilen].Cells[0].Value.ToString();
        }

        private void dataG_anakart_MouseClick(object sender, MouseEventArgs e)
        {
            dataSecim(dataG_anakart);
        }

        private void dataG_islemci_MouseClick(object sender, MouseEventArgs e)
        {
            dataSecim(dataG_islemci);
        }

        private void dataG_ram_MouseClick(object sender, MouseEventArgs e)
        {
            dataSecim(dataG_ram);
        }

        private void dataG_ekranK_MouseClick(object sender, MouseEventArgs e)
        {
            dataSecim(dataG_ekranK);
        }

        private void dataG_monitor_MouseClick(object sender, MouseEventArgs e)
        {
            dataSecim(dataG_monitor);
        }

        private void dataG_kasa_MouseClick(object sender, MouseEventArgs e)
        {
            dataSecim(dataG_kasa);
        }

        private void dataG_sesK_MouseClick(object sender, MouseEventArgs e)
        {
            dataSecim(dataG_sesK);
        }

        private void dataG_siviS_MouseClick(object sender, MouseEventArgs e)
        {
            dataSecim(dataG_siviS);
        }


        private void btn_anakart_kaydiSil_Click(object sender, EventArgs e)
        {
            kayitSil("Anakart_ad", "table_anakart");
        }

        private void btn_islemci_kayitSil_Click(object sender, EventArgs e)
        {
            kayitSil("islemci_ad", "table_islemci");
        }

        private void btn_ram_kayitSil_Click(object sender, EventArgs e)
        {
            kayitSil("Ram_name", "tableRam");
        }

        private void btn_ekranK_kayitSil_Click(object sender, EventArgs e)
        {
            kayitSil("EkranK_ad", "tableEkranK");
        }

        private void btn_monitor_kayitSil_Click(object sender, EventArgs e)
        {
            kayitSil("monitor_isim", "table_monitor");
        }

        private void btn_kasa_kayitSil_Click(object sender, EventArgs e)
        {
            kayitSil("Kasa_ad", "table_kasa");
        }

        private void btn_sesK_kayitSil_Click(object sender, EventArgs e)
        {
            kayitSil("Seskarti_ad", "tableSesK");
        }

        private void btn_siviS_kayitSil_Click(object sender, EventArgs e)
        {
            kayitSil("Cooling_ad", "tableCooling");
        }

        private void btn_kullanicilar_kayitSil_Click(object sender, EventArgs e)
        {
            if (geciciTasiyici.Equals(null))
            {
                MessageBox.Show("Silme İşleminden Önce Bir Satır Seçiniz...", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand SilKomut = new SqlCommand("Delete From KullaniciGirisBilgileri where  mail = @pmail", Sql_operation.sqlConnect);
                Sql_operation.checkedConnection(Sql_operation.sqlConnect);

                SilKomut.Parameters.AddWithValue("@pmail", geciciTasiyici);
                SilKomut.ExecuteNonQuery();
                geciciTasiyici = null;
                MessageBox.Show("Başarıyla Silindi");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}


