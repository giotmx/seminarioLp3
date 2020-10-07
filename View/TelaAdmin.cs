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
    public partial class TelaAdmin : Form
    {
        public TelaAdmin()
        {
            InitializeComponent();
        }

        private void TelaAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarFamilia cf = new CadastrarFamilia();
            cf.Show();
            this.Hide();
        }

        private void adicionarP_Click(object sender, EventArgs e)
        {
            CadastroProduto cp = new CadastroProduto();
            cp.Show();
            this.Hide();
        }

        private void cadastrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProduto cp = new CadastroProduto();
            cp.Show();
            this.Hide();
        }

        private void cadastrarPromoçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarFamilia cf = new CadastrarFamilia();
            cf.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProduto cp = new CadastroProduto();
            cp.Show();
            this.Hide();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarFamilia cf = new CadastrarFamilia();
            cf.Show();
            this.Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
