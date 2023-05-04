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
    public partial class ToplananPcGetir : Form
    {
        public ToplananPcGetir()
        {
            InitializeComponent();
        }
        String SistemId = "0";

        private void btn_panelkapat_Click(object sender, EventArgs e)
        {
            
        }

        private void ToplananPcGetir_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bilgisayar_topla_main bilgisayar_Topla_Main = new Bilgisayar_topla_main();
            bilgisayar_Topla_Main.Show();
            this.Hide();
        }

        private void btn_kutulariTemizle_Click(object sender, EventArgs e)
        {
            txt_anakart.Clear();
            txt_ekranK.Clear();
            txt_islemci.Clear();
            txt_kasa.Clear();
            txt_power.Clear();
            txt_ram.Clear();
            txt_sivi.Clear();
            txt_sound.Clear();
        }
        
        private void btn_kayitEkle_Click(object sender, EventArgs e)
        {
            if(txt_anakart.Text.Equals("") || txt_islemci.Text.Equals("") || txt_ram.Text.Equals(""))
            {
                MessageBox.Show("Anakart İşlemci Veya Ram Olmadan Bilgisayar Çalışmaz...","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand EklemeIslemi = new SqlCommand("INSERT INTO table_kullaniciSistem (Kullanici_eposta,Kullanici_anakart,Kullanici_islemci," +
                    "Kullanici_ekrank,Kullanici_ram,Kullanici_power,Kullanici_kasa,Kullanici_sound,Kullanici_sivi) VALUES (@eposta,@anakart,@islemci,@ekrank,@ram,@power,@kasa,@sound,@sivi)", Sql_operation.sqlConnect);
                EklemeIslemi.Parameters.AddWithValue("@eposta", txt_eposta.Text);
                EklemeIslemi.Parameters.AddWithValue("@anakart", txt_anakart.Text);
                EklemeIslemi.Parameters.AddWithValue("@islemci", txt_islemci.Text);
                EklemeIslemi.Parameters.AddWithValue("@ekrank", txt_ekranK.Text);
                EklemeIslemi.Parameters.AddWithValue("@ram", txt_ram.Text);
                EklemeIslemi.Parameters.AddWithValue("@power", txt_power.Text);
                EklemeIslemi.Parameters.AddWithValue("@kasa", txt_kasa.Text);
                EklemeIslemi.Parameters.AddWithValue("@sound", txt_sound.Text);
                EklemeIslemi.Parameters.AddWithValue("@sivi", txt_sivi.Text);
                EklemeIslemi.ExecuteNonQuery();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM table_kullaniciSistem WHERE Kullanici_eposta = @Email", Sql_operation.sqlConnect);
                Sql_operation.checkedConnection(Sql_operation.sqlConnect);
                sqlCommand.Parameters.AddWithValue("@Email", Main.Kullanici_eposta);

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataSet dt = new DataSet();
                adapter.Fill(dt);
                datagrid_toplananPC.AutoGenerateColumns = true;
                datagrid_toplananPC.DataSource = dt.Tables[0];
                txt_eposta.Text = Main.Kullanici_eposta;



            }
        }

        private void datagrid_toplananPC_MouseClick(object sender, MouseEventArgs e)
        {
            int secilen = datagrid_toplananPC.SelectedCells[0].RowIndex;
            SistemId = datagrid_toplananPC.Rows[secilen].Cells[0].Value.ToString();
            

        }

        private void datagrid_toplananPC_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int secilen = datagrid_toplananPC.SelectedCells[0].RowIndex;
            txt_anakart.Text = datagrid_toplananPC.Rows[secilen].Cells[2].Value.ToString();
            txt_islemci.Text = datagrid_toplananPC.Rows[secilen].Cells[3].Value.ToString();
            txt_ekranK.Text = datagrid_toplananPC.Rows[secilen].Cells[4].Value.ToString();
            txt_ram.Text = datagrid_toplananPC.Rows[secilen].Cells[5].Value.ToString();
            txt_power.Text = datagrid_toplananPC.Rows[secilen].Cells[6].Value.ToString();
            txt_kasa.Text = datagrid_toplananPC.Rows[secilen].Cells[7].Value.ToString();
            txt_sound.Text = datagrid_toplananPC.Rows[secilen].Cells[8].Value.ToString();
            txt_sivi.Text = datagrid_toplananPC.Rows[secilen].Cells[9].Value.ToString();
        }

        private void btn_kayitSil_Click(object sender, EventArgs e)
        {
            if(SistemId.Equals("0"))
            {
                MessageBox.Show("Silme İşleminden Önce Bir Satır Seçiniz...","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand SilKomut = new SqlCommand("Delete From table_kullaniciSistem where Sistem_id = @sistemId", Sql_operation.sqlConnect);
                Sql_operation.checkedConnection(Sql_operation.sqlConnect);

                SilKomut.Parameters.AddWithValue("@sistemId", SistemId);
                SilKomut.ExecuteNonQuery();
            }
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM table_kullaniciSistem WHERE Kullanici_eposta = @Email", Sql_operation.sqlConnect);
            Sql_operation.checkedConnection(Sql_operation.sqlConnect);
            sqlCommand.Parameters.AddWithValue("@Email", Main.Kullanici_eposta);

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataSet dt = new DataSet();
            adapter.Fill(dt);
            datagrid_toplananPC.AutoGenerateColumns = true;
            datagrid_toplananPC.DataSource = dt.Tables[0];
            SistemId = "0";

        }
    }
}
