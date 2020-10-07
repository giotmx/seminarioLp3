using e_aquila.Controler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_aquila.Model
{
    public class Controle
    {
        public string[] exists;
        public String aviso = "";

        public string[] verificarLogin(String login, String senha)
        {
            ComandosLogin l = new ComandosLogin();
            exists = l.verificarLogin(login, senha);

            if (!l.aviso.Equals(""))
            {
                this.aviso = l.aviso;
            }

            return exists;
        }

        public String cadastrar(String cpf, string nome, String login, String senha, String confSenha)
        {
            ComandosLogin l = new ComandosLogin();
            l.cadastrar(cpf, nome, login, senha, confSenha);

            if (!l.aviso.Equals(""))
            {
                this.aviso = l.aviso;
            }
            return aviso;
        }
    }
}
