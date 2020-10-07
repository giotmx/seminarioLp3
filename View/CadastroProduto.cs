using e_aquila.Controler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_aquila.View
{
    public partial class CadastroProduto : Form
    {
        SqlCommand c = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dtr;
        bool escolha = false;
        public override bool AutoSize { get; set; }

        public CadastroProduto()
        {
            InitializeComponent();
            this.txtpath.AutoSize = false;
            this.txtpath.Height = 24;
            this.txttitulo.AutoSize = false;
            this.txttitulo.Height = 24;
            this.txtdescricao.AutoSize = false;
            this.txtdescricao.Height = 24;
            this.txtpreco.AutoSize = false;
            this.txtpreco.Height = 24;
            this.txtestoque.AutoSize = false;
            this.txtestoque.Height = 24;
            cadastrarToolStripMenuItem.BackColor = Color.PowderBlue;
            tornarVisivelCad(true);
        }

        public void tornarVisivelAt(bool i)
        {
            groupAtualizar.Visible = i;
        }

        public void tornarVisivelCad(bool i)
        {
            groupCadastrar.Visible = i;
        }

        public int verificaPreenchimentoCad()
        {
            if (txttitulo.Text != null && txtpath.Text != null && txtdescricao.Text != null && txtestoque.Text != null && txtpreco.Text != null)
                return 1;
            else
                return 0;
        }

        public int verificaPreenchimentoAtt()
        {
            if (txttituloAt.Text != null && txtpathAt.Text != null && txtdescricaoAt.Text != null && txtestoqueAt.Text != null && txtprecoAt.Text != null)
                return 1;
            else
                return 0;
        }

        public void populaCombobox()
        {
            c.CommandText = "select * from Produtos";
            c.Connection = con.conectar();
            dtr = c.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(dtr);

            comboBoxProdutos.DisplayMember = "Titulo";
            comboBoxProdutos.ValueMember = "ID";
            comboBoxProdutos.DataSource = dataTable;

            con.desconectar();
            c.Dispose();
            dtr.Close();
            c.Parameters.Clear();
        }

        public Image Picture
        {
            
            get
            {
                if (!string.IsNullOrEmpty(txtpath.Text))
                {
                    if (File.Exists(txtpath.Text))
                    {
                        return Image.FromFile(txtpath.Text);
                    }
                }
                return null;
            }
        }


        private void atualizarEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrarToolStripMenuItem.BackColor = Color.White;
            atualizarEstoqueToolStripMenuItem.BackColor = Color.PowderBlue;
            populaCombobox();
            tornarVisivelAt(true);
            tornarVisivelCad(false);
            
        }


        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrarToolStripMenuItem.BackColor = Color.PowderBlue;
            atualizarEstoqueToolStripMenuItem.BackColor = Color.White;
            escolha = false;
            tornarVisivelCad(true);
            tornarVisivelAt(false);
        }

        private void buttoncadastrar_Click(object sender, EventArgs e)
        {
            int aux = verificaPreenchimentoCad();
            if (aux == 1)
            {
                c.CommandText = "insert into Produtos Values(@pat, @tit, @des, @prec, @est, @stat)";
                c.Parameters.AddWithValue("@pat", txtpath.Text);
                c.Parameters.AddWithValue("@tit", txttitulo.Text);
                c.Parameters.AddWithValue("@des", txtdescricao.Text);
                c.Parameters.AddWithValue("@prec", txtpreco.Text);
                c.Parameters.AddWithValue("@est", txtestoque.Text);
                if (radiolancamento.Checked)
                    c.Parameters.AddWithValue("@stat", 1);
                else
                    c.Parameters.AddWithValue("@stat", 0);
                c.Connection = con.conectar();
                dtr = c.ExecuteReader();

                con.desconectar();
                c.Dispose();
                dtr.Close();
                c.Parameters.Clear();
                MessageBox.Show("Produto cadastrado!");
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void buttonprocurar_Click(object sender, EventArgs e)
        {
            txtpath.Clear();
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
                txtpath.Text += ofd.FileName;

            }
            pictureProduto.Image = Picture;
        }

        private void comboBoxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aux = comboBoxProdutos.SelectedIndex + 1;
            if (escolha == true)
            {
                c.CommandText = "select * from Produtos WHERE ID = @id";
                c.Parameters.AddWithValue("@id", aux.ToString());
                c.Connection = con.conectar();
                dtr = c.ExecuteReader();

                if (dtr.Read())
                {
                    try
                    {
                        pictureBox1.Image = Image.FromFile(dtr[1].ToString());
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Este produto não possui imagem, atualize-a!");
                    }
                    txtpathAt.Text = dtr[1].ToString();
                    txttituloAt.Text = dtr[2].ToString();
                    txtdescricaoAt.Text = dtr[3].ToString();
                    txtprecoAt.Text = dtr[4].ToString();
                    txtestoqueAt.Text = dtr[5].ToString();

                    if (int.Parse(dtr[6].ToString()) == 1)
                        radioButton1.Checked = true;
                    else
                        radioButton1.Checked = false;
                }
            }
            escolha = true;

            con.desconectar();
            c.Dispose();
            dtr.Close();
            c.Parameters.Clear();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            int aux = comboBoxProdutos.SelectedIndex + 1;
            int aux2 = verificaPreenchimentoAtt();

            if (aux2 == 1)
            {
                c.CommandText = "update Produtos SET path = @pat, Titulo  = @tit, Descrição = @des, Preço = @prec, Estoque = @est, Status = @stat" +
                    " WHERE ID = @id";
                c.Parameters.AddWithValue("@pat", txtpathAt.Text);
                c.Parameters.AddWithValue("@tit", txttituloAt.Text);
                c.Parameters.AddWithValue("@des", txtdescricaoAt.Text);
                c.Parameters.AddWithValue("@prec", txtprecoAt.Text);
                c.Parameters.AddWithValue("@est", txtestoqueAt.Text);
                c.Parameters.AddWithValue("@id", aux.ToString());
                if (radioButton1.Checked)
                    c.Parameters.AddWithValue("@stat", 1);
                else
                    c.Parameters.AddWithValue("@stat", 0);

                c.Connection = con.conectar();
                dtr = c.ExecuteReader();

                con.desconectar();
                c.Dispose();
                dtr.Close();
                c.Parameters.Clear();

                populaCombobox();
                MessageBox.Show("Produto atualizado com sucesso!");
            }
            else
                MessageBox.Show("Todos os campos tem que estar preenchidos!");
        }

        private void buttonProcurarImg_Click(object sender, EventArgs e)
        {
            txtpath.Clear();
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
                txtpath.Text += ofd.FileName;

            }
            pictureBox1.Image = Picture;
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaAdmin ta = new TelaAdmin();
            ta.Show();
            this.Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

