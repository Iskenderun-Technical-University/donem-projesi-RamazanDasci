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
    public partial class Admin_giris : Form
    {
        public Admin_giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_password.Text.Equals("") || txt_id.Text.Equals(""))
            {
                MessageBox.Show("Lütfen Kutucukları Boş Bırakmayınız", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                //SQL Bağlantısı Sağlanacak
                SqlCommand command = new SqlCommand("Select * from table_admin WHERE admin_id=@pid and admin_password=@pPassword", Sql_operation.sqlConnect);
                Sql_operation.checkedConnection(Sql_operation.sqlConnect);
                command.Parameters.AddWithValue("@pid", txt_id.Text);
                command.Parameters.AddWithValue("@pPassword", txt_password.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                String a = adapter.ToString();

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Başarıyla Giriş Yapıldı", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    admin_panel admin_Panel = new admin_panel();
                    admin_Panel.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı Veya Parola Hatalı", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }



            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                txt_password.UseSystemPasswordChar = true; 
            }
            else
            {
                txt_password.UseSystemPasswordChar = false;
            }
        }

        private void Admin_giris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
