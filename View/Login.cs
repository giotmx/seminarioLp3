using e_aquila.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_aquila.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.verificarLogin(textBox1.Text, textBox2.Text);

            if (controle.aviso.Equals(""))
            {
                if (controle.exists[0] == "true")
                {
                    MessageBox.Show("Logado com sucesso: " + controle.exists[1], "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(controle.exists[1] == "false")
                    {
                        TelaInicial ti = new TelaInicial(controle.exists);
                        ti.Show();
                        this.Hide();
                    }
                    else if(controle.exists[1] == "true")
                    {
                        TelaAdmin ta = new TelaAdmin();
                        ta.Show();
                        this.Hide();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Login não encontrado, verifique o login e senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show(controle.aviso);
            }
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            Cadastro c = new Cadastro();
            c.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}