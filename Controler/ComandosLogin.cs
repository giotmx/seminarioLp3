using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_aquila.Controler
{
    public class ComandosLogin
    {
        public string exists = "false";
        public String aviso = "";
        SqlCommand c = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dtr;
        string[] tipoU = new string[4];

        public string[] verificarLogin(String login, String senha)
        {
            c.CommandText = "select * from Users where username = @login and password = @senha";
            c.Parameters.AddWithValue("@login", login);
            c.Parameters.AddWithValue("@senha", senha);

            try
            {
                c.Connection = con.conectar();
                dtr = c.ExecuteReader();
                if (dtr.HasRows)
                {
                    exists = "true";
                    if (dtr.Read())
                    {
                        MessageBox.Show(dtr[6].ToString());
                        if (dtr[6].ToString().Contains("admin"))
                        {
                            tipoU[1] = "true";
                            tipoU[2] = dtr[5].ToString();
                            MessageBox.Show(dtr[1].ToString());
                            tipoU[3] = dtr[1].ToString();
                        }
                        else
                        {
                            tipoU[1] = "false";
                            MessageBox.Show(dtr[1].ToString());
                            tipoU[3] = dtr[1].ToString();
                        }
                    }
                }
            }
            catch (SqlException)
            {
                this.aviso = "Erro com o banco de dados!";
            }
            tipoU[0] = exists;
            return tipoU;
        }
        public String cadastrar(String cpf, string nome, String login, String senha, String confSenha)
        {
            if (senha != confSenha)
            {
                this.aviso = "Senhas não coincidem!";
            }
            else
            {
                c.CommandText = "INSERT INTO Users VALUES(@id, @name, @lg, @pass, 'new', 'user')";
                c.Parameters.AddWithValue("@id", cpf);
                c.Parameters.AddWithValue("@name", nome);
                c.Parameters.AddWithValue("@lg", login);
                c.Parameters.AddWithValue("@pass", senha);

                try
                {
                    c.Connection = con.conectar();
                    dtr = c.ExecuteReader();
                    this.aviso = "Inserido com sucesso";
                }
                catch (SqlException)
                {
                    this.aviso = "Erro com o banco de dados!";
                }
            }
            return aviso;
        }
    }
}

