using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Bilgisayar_Toplama_Otomasyonu.Sql_degiskenleri;

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
            //Bilgisayar Toplama Ekranından Main Ekranına Gitmek İçin Kontroller Ve Gidiş
            if(Main.girisYapildiMi==1)
            {
                
                //Giriş Yapıldıysa Giriş Bilgilerini Yazdırıp Öyle Ana Ekrana Gidilir
                Bakim_Toplama_ayrimi ayrimNesne = new Bakim_Toplama_ayrimi();
                ayrimNesne.lbl_hesapInfo.Text = Main.Kullanici_eposta;
                ayrimNesne.Show();
                this.Hide();
            }
            else
            {
                //Giriş Yapılmadıysa Herhangi Bir İşlem Yapmadan Ana Ekrana Gidilir
                Bakim_Toplama_ayrimi ayrimNesne = new Bakim_Toplama_ayrimi();
                ayrimNesne.Show();
                this.Hide();
            }
            
        }
        
        


        private void btn_robotclstr_Click(object sender, EventArgs e)
        {
            //Bilgisayar Toplamak İçin Robotu Çalıştırma Butonu
            if(cmbox_anaIstek.Text.Equals("Lütfen Bir Seçim Yapınız...") || cmbox_monitorSecim.Text.Equals("Lütfen Bir Seçim Yapınız...") || cmbox_seviyeBelirt.Text.Equals("Lütfen Bir Seçim Yapınız..."))
            {
                MessageBox.Show("Çoklu Seçimleri Lütfen Doldurunuz","Dikkat",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //ROBOT ÇALIŞMA KODLARI
                RobotFormu robotFormu = new RobotFormu();

                if(!chc_rgb.Checked)
                {
                    robotFormu.cmbox_rgbFan.Enabled = false;
                    robotFormu.cmbox_rbgController.Enabled = false;
                    robotFormu.cmbox_rgbFan.BackColor = Color.Gray;
                    robotFormu.cmbox_rbgController.BackColor = Color.Gray;
                    robotFormu.cmbox_rbgController.Text = "Sisteminizde RGB tanımlı değil.";
                    robotFormu.cmbox_rgbFan.Text = "Sisteminizde RGB tanımlı Değil.";
                }
                if (chc_sivisogutucu.Checked)
                {
                    robotFormu.cmbox_sivisogutucu.Enabled = true;
                    robotFormu.cmbox_sivisogutucu.BackColor = Color.White;
                    robotFormu.cmbox_sivisogutucu.Text = "";
                    sqlforrobot("SELECT * FROM tableCooling ", robotFormu.cmbox_sivisogutucu);
                }
                if (chc_music.Checked)
                {
                    robotFormu.cmbox_seskarti.Enabled = true;
                    robotFormu.cmbox_seskarti.BackColor = Color.White;
                    robotFormu.cmbox_seskarti.Text = "";
                    sqlforrobot("SELECT * FROM tableSesK ", robotFormu.cmbox_seskarti);
                }
                if (chc_rgb.Checked)
                {
                    //RGB İSTENİLDİĞİNDE NE YAPSIN?
                }
                if (cmbox_monitorSecim.Text.Contains("1"))
                {
                    
                    sqlforrobot("SELECT * FROM table_monitor WHERE id<=13", robotFormu.cmbox_monitor);
                }
                else if (cmbox_monitorSecim.Text.Contains("2"))
                {
                    sqlforrobot("SELECT * FROM table_monitor WHERE id>13 and id<=23", robotFormu.cmbox_monitor);
                }
                else if(cmbox_monitorSecim.Text.Contains("3"))
                {
                    sqlforrobot("SELECT * FROM table_monitor WHERE id>23", robotFormu.cmbox_monitor);
                }
                else
                {
                    //SİSTEMDE MONİTÖR İSTEMİYORUM KODLARI
                }
                if (cmbox_anaIstek.Text.Contains("1"))
                {

                    sqlforrobot("SELECT * FROM table_islemci WHERE id>20", robotFormu.cmbox_islemci);
                    sqlforrobot("SELECT * FROM table_anakart WHERE id>20", robotFormu.cmbox_anakart);
                    sqlforrobot("SELECT * FROM tableRam WHERE id>20",     robotFormu.cmbox_ram);
                    sqlforrobot("SELECT * FROM table_kasa WHERE id>20",    robotFormu.cmbox_kasa);
                    sqlforrobot("SELECT * FROM tableEkranK WHERE id>20", robotFormu.cmbox_ekrankarti);
                }
                else if (cmbox_anaIstek.Text.Contains("2"))
                {
                    sqlforrobot("SELECT * FROM table_islemci WHERE id>10 and id<=20", robotFormu.cmbox_islemci);
                    sqlforrobot("SELECT * FROM table_anakart WHERE id>10 and id<=20", robotFormu.cmbox_anakart);
                    sqlforrobot("SELECT * FROM tableRam WHERE id>10 and id<=20", robotFormu.cmbox_ram);
                    sqlforrobot("SELECT * FROM table_kasa WHERE id>10 and id<=20", robotFormu.cmbox_kasa);
                    sqlforrobot("SELECT * FROM tableEkranK WHERE id>10 and id<=20", robotFormu.cmbox_ekrankarti);
                }
                else if (cmbox_anaIstek.Text.Contains("3"))
                {
                    sqlforrobot("SELECT * FROM table_islemci WHERE id<=10", robotFormu.cmbox_islemci);
                    sqlforrobot("SELECT * FROM table_anakart WHERE id<=10", robotFormu.cmbox_anakart);
                    sqlforrobot("SELECT * FROM tableRam WHERE id<=10", robotFormu.cmbox_ram);
                    sqlforrobot("SELECT * FROM table_kasa WHERE id<=10", robotFormu.cmbox_kasa);
                    sqlforrobot("SELECT * FROM tableEkranK WHERE id<=10", robotFormu.cmbox_ekrankarti);
                }
                else if (cmbox_anaIstek.Text.Contains("5"))
                {
                    sqlforrobot("SELECT * FROM table_islemci WHERE id<=10", robotFormu.cmbox_islemci);
                    sqlforrobot("SELECT * FROM table_anakart WHERE id<=10", robotFormu.cmbox_anakart);
                    sqlforrobot("SELECT * FROM tableRam WHERE id<=10", robotFormu.cmbox_ram);
                    sqlforrobot("SELECT * FROM table_kasa WHERE id<=10", robotFormu.cmbox_kasa);
                    sqlforrobot("SELECT * FROM tableEkranK WHERE id<=10", robotFormu.cmbox_ekrankarti);
                }
                
                else
                {
                    MessageBox.Show("Sunucu Bilgisayarları Çok Yakında...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                robotFormu.Show();
                this.Hide();
                

            }
            
        }
        public void sqlforrobot(String sqlkomut,  ComboBox comboBox  )
        {
            SqlCommand sqlCommand = new SqlCommand(sqlkomut,Sql_operation.sqlConnect);
            Sql_operation.checkedConnection(Sql_operation.sqlConnect);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while(reader.Read())
            {
               comboBox.Items.Add(reader.GetString(1)); // kayıt ekle

            }
            reader.Close();




        }

        private void btn_toplananPCgetir_Click(object sender, EventArgs e)
        {
            //Kullanıcının Daha Önceden Toplayıp Kayıt Ettiği Bilgisayarları Sıralar Veya Toplama Bilgisayar Kayıtları Hakkında İşlemler Yapar
            if(Main.girisYapildiMi==1)
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM table_kullaniciSistem WHERE Kullanici_eposta = @Email", Sql_operation.sqlConnect);
                Sql_operation.checkedConnection(Sql_operation.sqlConnect);
                sqlCommand.Parameters.AddWithValue("@Email", Main.Kullanici_eposta );

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataSet dt = new DataSet();
                adapter.Fill(dt);

                ToplananPcGetir toplananPcGetir = new ToplananPcGetir();
                toplananPcGetir.txt_eposta.Text = Main.Kullanici_eposta;

                if (dt.Tables[0].Rows.Count == 0)
                {
                    //Kayıtlı Eposta Adına Bilgisayar Yoksa Uyarı Verir
                    toplananPcGetir.Show();
                    this.Hide();
                    MessageBox.Show("Kayıtlı Herhangi Bir Bilgisayar Bulunamamıştır!!!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    //Kayıtlı Epostada Bilgisayar Varsa Onları DataGride Aktarır
                    
                    toplananPcGetir.datagrid_toplananPC.AutoGenerateColumns = true;
                    toplananPcGetir.datagrid_toplananPC.DataSource = dt.Tables[0];
                    
                    toplananPcGetir.Show();
                    this.Hide();
                }

            }
            //Giriş Yapılmadıysa Toplanan pc Kayıtları Çalışmaz
            else
            {
                MessageBox.Show("Bu Özelliği Kullanabilmek İçin Giriş Yapmalısınız", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
       

        
    }
}
