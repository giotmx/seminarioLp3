using e_aquila.Model;
using e_aquila.Controler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_aquila.View
{
    public partial class TelaInicial : Form
    {
        string[] controle;
        public TelaInicial(string[] c)
        {
            InitializeComponent();
            controle = c;
        }
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            using(DbPicAquilaEntities db = new DbPicAquilaEntities())
            {
                if(db.Produtos.ToList() != null)
                    produtoBindingSource.DataSource = db.Produtos.ToList();
            }
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaSelec;
            linhaSelec = dataGridView1.CurrentRow.Index; // pega o indice da linha selecionada.
            ProdutoSelec pselec = new ProdutoSelec(linhaSelec + 1, controle);
            pselec.Show();
            this.Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login ti = new Login();
            ti.Show();
            this.Hide();
        }

        private void produtoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
