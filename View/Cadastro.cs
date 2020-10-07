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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pass1txt.Text != pass2txt.Text)
            {
                MessageBox.Show("As senhas não coicidem!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Controle controle = new Controle();
                controle.cadastrar(cpftxt.Text, nometxt.Text, usertxt.Text, pass1txt.Text, pass2txt.Text);
                MessageBox.Show(controle.aviso, "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Login ti = new Login();
            ti.Show();
            this.Hide();
        }
    }
}
