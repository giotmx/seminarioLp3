using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_aquila.Controler
{
    public class Conexao { 

        private static SqlConnection _conexao;
        private SqlConnection con;
        public Conexao()
        {
            if (_conexao == null)
            {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source=LAPTOP-MO76977T\SQLEXPRESS;Initial Catalog=Aquila;Integrated Security=True";
                MessageBox.Show("Conexao nula");            
            }
            else
                MessageBox.Show("Mesma conexao");
        }

        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
                _conexao = null;
            }
        }
    }
}
