using e_aquila.Controler;
using e_aquila.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_aquila.View
{
    public partial class ProdutoSelec : Form
    {
        SqlCommand c = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dtr;
        string[] controle = new string[4];
        int ind;

        public ProdutoSelec(int indice, string[] cont)
        {
            InitializeComponent();
            controle = cont;
            ind = indice;
            titulo.Text = indice.ToString();
            con.conectar();

            c.CommandText = "select * from Produtos where ID = @id";
            c.Parameters.AddWithValue("@id", indice);

            c.Connection = con.conectar();
            dtr = c.ExecuteReader();

            if (dtr.Read())
            {
                pictureBox.Image = Image.FromFile(dtr[1].ToString());
                titulo.Text = dtr[2].ToString();
                descricao.Text = dtr[3].ToString();
                preco.Text = dtr[4].ToString();
                estoque.Text = dtr[5].ToString();

                if (int.Parse(dtr[5].ToString()) == 0)
                {
                    comprar.Visible = false;
                    aviso.Visible = true;    
                }
                else
                {
                    comprar.Visible = true;
                    aviso.Visible = false;
                }

                if(dtr[6].ToString() == "1")
                {
                    newP.Visible = true;
                }

            }

             dtr.Close();
             con.desconectar();
        }

        private void ProdutoSelec_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaInicial ti = new TelaInicial();
            ti.Show();
            this.Hide();
            
        }

        private void addP_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            e_Produto p1 = new Produto(double.Parse(preco.Text));

            p1 = new FreteNormal(p1);

            label2.Text = p1.getPreco().ToString();
            label2.Visible = true;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            e_Produto p1 = new Produto(double.Parse(preco.Text));

            p1 = new FreteFull(p1);

            label2.Text = p1.getPreco().ToString();
            label2.Visible = true;

        }

        private void comprar_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked || radioButton2.Checked)
            {
                CompraFinalizada cf = new CompraFinalizada(float.Parse(label2.Text), controle) ;
                cf.Show();
            }
            else
            {
                MessageBox.Show("Selecione o frete!");
            }
        }

        private void aviso_Click(object sender, EventArgs e)
        {
            c.CommandText = "insert into Interesse Values(@cpf, @idp)";
            c.Parameters.AddWithValue("@cpf", controle[3].ToString());
            c.Parameters.AddWithValue("@idp", ind.ToString());
            c.Connection = con.conectar();
            dtr = c.ExecuteReader();

            con.desconectar();
            c.Dispose();
            dtr.Close();
            c.Parameters.Clear();
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
