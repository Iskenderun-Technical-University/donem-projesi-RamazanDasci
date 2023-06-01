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
using System.Security.Cryptography.X509Certificates;

namespace Bilgisayar_Toplama_Otomasyonu
{
    public partial class kayit_form : Form
    {
        public kayit_form()
        {
            InitializeComponent();
        }

        private void kayit_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Forumdan Çıkış Yapıldığında Uygulamayı Kapatır
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Parolayı Görünür veya Gizlemeye Yarar
            if (checkBox1.Checked == false)
            {
                txt_parola.UseSystemPasswordChar = true;
                txt_parolaYeniden.UseSystemPasswordChar = true;
            }
            else
            {
                txt_parolaYeniden.UseSystemPasswordChar = false;
                txt_parola.UseSystemPasswordChar = false;
            }
        }


        private void rjButton1_Click(object sender, EventArgs e)
        {

            SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM KullaniciGirisBilgileri WHERE mail = @Email", Sql_operation.sqlConnect);
            Sql_operation.checkedConnection(Sql_operation.sqlConnect);
            sqlCommand.Parameters.AddWithValue("@Email", txt_ePosta.Text);
            int count = (int)sqlCommand.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("E-posta Adresi Daha Önce Alınmış", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                //Kayıt için girilen değerlerin kriterlere uygunluğunu kontrol eder
                if (txt_ePosta.Text.Equals("") || txt_kullaniciAdi.Text.Equals("") || txt_parola.Text.Equals("") || txt_parolaYeniden.Text.Equals(""))
                {
                    MessageBox.Show("Kutucuklardan Birisi Veya Birden Fazlası Boş Olamaz", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!txt_parola.Text.Equals(txt_parolaYeniden.Text))
                {
                    MessageBox.Show("Parolarınız Eşleşmiyor", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!txt_ePosta.Text.Contains("@") || !txt_ePosta.Text.Contains(".com"))
                {
                    MessageBox.Show("Gerçek Bir E-posta Adresi Girin", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //Kullanıcıyı Veri Tabanına Kayıt Eder
                else
                {
                    SqlCommand CommandRegister = new SqlCommand("INSERT INTO KullaniciGirisBilgileri (name, password, mail) VALUES (@pKullaniciAdi,@pPassword,@pmail)", Sql_operation.sqlConnect);


                    Sql_operation.checkedConnection(Sql_operation.sqlConnect);
                    CommandRegister.Parameters.AddWithValue("@pKullaniciAdi", txt_kullaniciAdi.Text);
                    CommandRegister.Parameters.AddWithValue("@pPassword", txt_parola.Text);
                    CommandRegister.Parameters.AddWithValue("@pmail", txt_ePosta.Text);



                    CommandRegister.ExecuteNonQuery();
                    MessageBox.Show("Kullanıcı Başarıyla Kayıt Edildi", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Main main = new Main();
                    main.Show();
                    this.Hide();

                }
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
