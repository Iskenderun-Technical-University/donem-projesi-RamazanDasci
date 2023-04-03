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

        private void btn_kayitOl_Click(object sender, EventArgs e)
        {
            //Kayıt için girilen değerlerin kriterlere uygunluğunu kontrol eder
            if(txt_ePosta.Text.Equals("") || txt_kullaniciAdi.Text.Equals("") || txt_parola.Text.Equals("") || txt_parolaYeniden.Text.Equals(""))
            {
                MessageBox.Show("Kutucuklardan Birisi Veya Birden Fazlası Boş Olamaz","Dikkat",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(!txt_parola.Text.Equals(txt_parolaYeniden.Text))
            {
                MessageBox.Show("Parolarınız Eşleşmiyor","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if(!txt_ePosta.Text.Contains("@") || !txt_ePosta.Text.Contains(".com"))
            {
                MessageBox.Show("Gerçek Bir E-posta Adresi Girin", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Kullanıcıyı Veri Tabanına Kayıt Eder
            else
            {
                
            }
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
    }
}
