using Bilgisayar_Toplama_Otomasyonu.Sql_degiskenleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bilgisayar_Toplama_Otomasyonu
{
    public partial class sifremiUnuttum : Form
    {
        public sifremiUnuttum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_girisEkrani_Click(object sender, EventArgs e)
        {
            
        }

        private void sifremiUnuttum_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM KullaniciGirisBilgileri WHERE mail=@pmail and name=@pname", Sql_operation.sqlConnect);
            Sql_operation.checkedConnection(Sql_operation.sqlConnect);
            command.Parameters.AddWithValue("@pmail", txt_eposta.Text);
            command.Parameters.AddWithValue("@pname", txt_isim.Text);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                String sifre = reader.GetString(1);
                MessageBox.Show("Kayıtlı Şifreniz Bulunmuştur: " + sifre, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kayıtlı Şifreniz Bulunamamıştır ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            reader.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void sifremiUnuttum_Load(object sender, EventArgs e)
        {

        }
    }
}
