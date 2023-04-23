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
    public partial class RobotFormu : Form
    {
        public RobotFormu()
        {
            InitializeComponent();
        }

        private void RobotFormu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_toplaMain_Click(object sender, EventArgs e)
        {
            Bilgisayar_topla_main bilgisayar_Topla_Main = new Bilgisayar_topla_main();
            bilgisayar_Topla_Main.Show();
            this.Hide();
        }

        public int islemciId = 0; 
        public int EkrankartiId = 0;
        public void cmbox_islemci_SelectedIndexChanged(object sender, EventArgs e)
        {
            //İşlemci id getirip kontrol ediyor
            SqlCommand sqlCommand = new SqlCommand("SELECT id FROM table_islemci WHERE islemci_ad=@pIslemciIsim ", Sql_operation.sqlConnect);
            Sql_operation.checkedConnection(Sql_operation.sqlConnect);
            sqlCommand.Parameters.AddWithValue("@pIslemciIsim", cmbox_islemci.Text);


            Object idValue = sqlCommand.ExecuteScalar();
            
                 String id = idValue.ToString();
                 islemciId = Int32.Parse(id);
                 islemciekrankKontol();

        }

        private void cmbox_ekrankarti_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Ekran Kartı id getirip kontrol ediyor
            SqlCommand sqlCommand = new SqlCommand("SELECT id FROM tableEkranK WHERE EkranK_ad=@pEkranKIsım ", Sql_operation.sqlConnect);
            Sql_operation.checkedConnection(Sql_operation.sqlConnect);
            sqlCommand.Parameters.AddWithValue("@pEkranKIsım", cmbox_ekrankarti.Text);


            Object idValue = sqlCommand.ExecuteScalar();

            String id = idValue.ToString();
            EkrankartiId = Int32.Parse(id);
            islemciekrankKontol();
        }

        public void islemciekrankKontol ()
        {
            //Ekran kartı ve islemcinin idlerini kontrol ediyor
            if(islemciId == 0 || EkrankartiId == 0)
            {

            }
            else
            {
                if(islemciId - EkrankartiId > 5 || islemciId - EkrankartiId < -5)
                {
                    lbl_uyari.Text = "İşlemci ve Ekran Kartı Uyumlu Çalışmayabilir!!!";
                }
                else
                {
                    lbl_uyari.Text = "Sorun Görünmüyor";
                }
            }
        }

        private void btn_robotKayit_Click(object sender, EventArgs e)
        {
            if (cmbox_ram.Text.Equals("") || cmbox_islemci.Text.Equals("") || cmbox_anakart.Text.Equals(""))
            {
                MessageBox.Show("Anakart İşlemci Ve Ram Olmadan Bilgisayar Kayıt Edemezsiniz...", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Main.girisYapildiMi==0)
                {
                    MessageBox.Show("Giriş Yapmadan Bu Özelliği Kullanamazsınız","Dikkat",MessageBoxButtons.OK , MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand EklemeIslemi = new SqlCommand("INSERT INTO table_kullaniciSistem (Kullanici_eposta,Kullanici_anakart,Kullanici_islemci," +
                    "Kullanici_ekrank,Kullanici_ram,Kullanici_kasa,Kullanici_sound,Kullanici_sivi) VALUES (@eposta,@anakart,@islemci,@ekrank,@ram,@kasa,@sound,@sivi)", Sql_operation.sqlConnect);
                    EklemeIslemi.Parameters.AddWithValue("@eposta", Main.Kullanici_eposta);
                    EklemeIslemi.Parameters.AddWithValue("@anakart", cmbox_anakart.Text);
                    EklemeIslemi.Parameters.AddWithValue("@islemci", cmbox_islemci.Text);
                    EklemeIslemi.Parameters.AddWithValue("@ekrank", cmbox_ekrankarti.Text);
                    EklemeIslemi.Parameters.AddWithValue("@ram", cmbox_ram.Text);
                    EklemeIslemi.Parameters.AddWithValue("@kasa", cmbox_kasa.Text);
                    EklemeIslemi.Parameters.AddWithValue("@sound", cmbox_seskarti.Text);
                    EklemeIslemi.Parameters.AddWithValue("@sivi", cmbox_sivisogutucu.Text);
                    EklemeIslemi.ExecuteNonQuery();
                    MessageBox.Show("Bilgisayar Başarıyla Kayıt Edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }

            
            
        }
    }
}
