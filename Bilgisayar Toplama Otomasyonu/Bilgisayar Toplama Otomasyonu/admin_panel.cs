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
    public partial class admin_panel : Form
    {
        public admin_panel()
        {
            InitializeComponent();
        }

        private void admin_panel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

      
    }
}



/*
 * SqlCommand sqlCommand = new SqlCommand("SELECT * FROM table_kullaniciSistem WHERE Kullanici_eposta = @Email", Sql_operation.sqlConnect);
                Sql_operation.checkedConnection(Sql_operation.sqlConnect);
                sqlCommand.Parameters.AddWithValue("@Email", Main.Kullanici_eposta);

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataSet dt = new DataSet();
                adapter.Fill(dt);
                datagrid_toplananPC.AutoGenerateColumns = true;
                datagrid_toplananPC.DataSource = dt.Tables[0];*/