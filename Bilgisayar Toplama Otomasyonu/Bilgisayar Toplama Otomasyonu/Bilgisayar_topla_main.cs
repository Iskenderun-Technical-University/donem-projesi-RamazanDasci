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
            }
            
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

                
                if (dt.Tables[0].Rows.Count == 0)
                {
                    //Kayıtlı Eposta Adına Bilgisayar Yoksa Uyarı Verir
                    MessageBox.Show("Kayıtlı Herhangi Bir Bilgisayar Bulunamamıştır!!!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Kayıtlı Epostada Bilgisayar Varsa Onları DataGride Aktarır
                    ToplananPcGetir toplananPcGetir = new ToplananPcGetir();
                    toplananPcGetir.datagrid_toplananPC.AutoGenerateColumns = true;
                    toplananPcGetir.datagrid_toplananPC.DataSource = dt.Tables[0];
                    toplananPcGetir.txt_eposta.Text=Main.Kullanici_eposta;
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
        public void datagridiGuncelle()
        {

        }
    }
}
