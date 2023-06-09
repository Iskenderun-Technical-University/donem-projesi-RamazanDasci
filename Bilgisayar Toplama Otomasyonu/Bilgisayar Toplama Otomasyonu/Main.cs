﻿using System;
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
using Bilgisayar_Toplama_Otomasyonu.With_ComputerDataSetTableAdapters;

namespace Bilgisayar_Toplama_Otomasyonu
{
    public partial class Main : Form
    {
        public static int girisYapildiMi = 0;
        public static String Kullanici_eposta;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                txt_password.UseSystemPasswordChar = true;
            }
            else
            {
                txt_password.UseSystemPasswordChar= false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Kayıt Ekranına Atar
            kayit_form kayitNesnesi = new kayit_form();
            kayitNesnesi.Show();
            this.Hide();
        }

        private void lnklbl_sifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sifremiUnuttum sifremiUnuttum = new sifremiUnuttum();
            this.Hide();
            sifremiUnuttum.Show();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void rjButton2_Click_1(object sender, EventArgs e)
        {

            //Giriş Bilgileri Kontrolünü Sağlar
            if (txt_password.Text.Equals("") || txt_userEposta.Text.Equals(""))
            {
                MessageBox.Show("Lütfen Kutucukları Boş Bırakmayınız", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Kullanici_eposta = txt_userEposta.Text;
                //SQL Bağlantısı Sağlanacak
                SqlCommand command = new SqlCommand("Select * from KullaniciGirisBilgileri WHERE mail=@pmail and password=@pPassword", Sql_operation.sqlConnect);
                Sql_operation.checkedConnection(Sql_operation.sqlConnect);
                command.Parameters.AddWithValue("@pmail", txt_userEposta.Text);
                command.Parameters.AddWithValue("@pPassword", txt_password.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                String a = adapter.ToString();

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Başarıyla Giriş Yapıldı", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    girisYapildiMi = 1;

                    Bakim_Toplama_ayrimi bakim_Toplama_Ayrimi = new Bakim_Toplama_ayrimi();
                    bakim_Toplama_Ayrimi.lbl_hesapInfo.Text = txt_userEposta.Text;
                    bakim_Toplama_Ayrimi.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı Veya Parola Hatalı", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }



            }
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            Bakim_Toplama_ayrimi ayrimNesnesi = new Bakim_Toplama_ayrimi();
            ayrimNesnesi.Show();
            this.Hide();
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            Admin_giris admin_Giris = new Admin_giris();
            admin_Giris.Show();
            this.Hide();
        }
    }
}
