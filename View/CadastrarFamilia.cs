using e_aquila.Controler;
using e_aquila.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_aquila.View
{
    public partial class CadastrarFamilia : Form
    {
        List<string> list = new List<string>();
        SqlCommand c = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dtr;
        string titulo;
        double valor;
        string descricao;
        int desconto;
        string familia;
        double porcent;
        string path;
        FamiliaProdutos fa = new FamiliaProdutos();
        List<Produto> lista = new List<Produto>();


        public CadastrarFamilia()
        {
            InitializeComponent();
            carregarList();
            c.Dispose();
            dtr.Close();
            c.Parameters.Clear();
        }

        private void carregarList()
        {
            con.conectar();

            c.CommandText = "select * from Produtos";
            c.Connection = con.conectar();
            dtr = c.ExecuteReader();

            while (dtr.Read())
            {
                Produto p1 = new Produto();
                p1.ID = int.Parse(dtr[0].ToString());
                p1.Path = dtr[1].ToString();
                p1.Titulo = dtr[2].ToString();
                p1.Descrição = dtr[3].ToString();
                p1.Preço = float.Parse(dtr[4].ToString());
                p1.Estoque = int.Parse(dtr[5].ToString());
                p1.Status = dtr[6].ToString();

                list.Add(p1.Titulo);

            }
            checkedListBox1.DataSource = list;
            con.desconectar();

        }

        private void CadastrarFamilia_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.conectar();

            foreach (string itemChecked in checkedListBox1.CheckedItems)
            {
                SqlCommand c2 = new SqlCommand();
                c2.CommandText = "select * from Produtos where Titulo = @t";
                c2.Parameters.AddWithValue("@t", itemChecked.ToString());
                c2.Connection = con.conectar();
                dtr = c2.ExecuteReader();

                if (dtr.Read())
                {
                    Produto p1 = new Produto();
                    p1.Path = dtr[1].ToString();
                    p1.Titulo = dtr[2].ToString();
                    p1.Descrição = dtr[3].ToString();
                    p1.Preço = float.Parse(dtr[4].ToString());
                    p1.Estoque = int.Parse(dtr[5].ToString());
                    p1.Status = dtr[6].ToString();

                    fa.adicionarProduto(p1);
                  

                    /*
                    ListViewItem item = new ListViewItem(p1.Titulo);
                    item.SubItems.Add(p1.Preço.ToString());
                    item.SubItems.Add(familia);
                    item.SubItems.Add(desconto.ToString());
                    this.listView1.Items.Add(item);

                    fa.adicionarProduto(p1);
                    con.desconectar();*/
                }

                lista = fa.retornaLista();

                c2.Dispose();
                dtr.Close();
                c2.Parameters.Clear();
            }

            //Adicionei as colunas que irei mostrar na listView
            listView1.Columns.Add("Titulo");
            listView1.Columns.Add("Familia");
            listView1.Columns.Add("Descricao");
            listView1.Columns.Add("Desconto");

            porcent = double.Parse(txtdesconto.Text) / 100;
            //Percorre a lista adicionando as linhas do ListView
            foreach (var item in lista)
            {
                SqlCommand c2 = new SqlCommand();
                listView1.Items.Add(new ListViewItem(new string[] { item.Titulo.ToString(), txtfamilia.Text, txtdescricao.Text, txtdesconto.Text }));
                
                titulo = item.Titulo;
                
                desconto = int.Parse(txtdesconto.Text);
                valor = item.Preço - (item.Preço * porcent);
                descricao = txtdescricao.Text;
                familia = txtfamilia.Text;
                path = txtpathlogo.Text;

                c2.CommandText = "insert into Familia Values(@pa, @fa, @t, @de, @do, @v)";
                c2.Parameters.AddWithValue("@pa", path);
                c2.Parameters.AddWithValue("@t", titulo);
                c2.Parameters.AddWithValue("@v", valor);
                c2.Parameters.AddWithValue("@do", desconto);
                c2.Parameters.AddWithValue("@de", descricao);
                c2.Parameters.AddWithValue("@fa", familia);
                c2.Connection = con.conectar();
                dtr = c2.ExecuteReader();


                c2.Dispose();
                dtr.Close();
                c2.Parameters.Clear();
                con.desconectar();
            }
            button1.Enabled = false;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            txtfamilia.Visible = true;
            txtdesconto.Visible = true;
            txtdescricao.Visible = true;
            button1.Enabled = true;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonProcurarImg_Click(object sender, EventArgs e)
        {
            txtpathlogo.Clear();
            this.ofd.Multiselect = true;
            this.ofd.Title = "Selecionar arquivo";
            ofd.InitialDirectory = @"C:\";
            ofd.Filter = "Images (*.JPG)|*.JPG";
            ofd.CheckFileExists = true;
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;
            ofd.ReadOnlyChecked = true;
            ofd.ShowReadOnly = true;

            DialogResult dr = this.ofd.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                txtpathlogo.Text += ofd.FileName;

            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
