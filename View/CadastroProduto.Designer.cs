namespace e_aquila.View
{
    partial class CadastroProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupCadastrar = new System.Windows.Forms.GroupBox();
            this.buttonprocurar = new System.Windows.Forms.Button();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttoncadastrar = new System.Windows.Forms.Button();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.radiolancamento = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureProduto = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtestoque = new System.Windows.Forms.TextBox();
            this.groupAtualizar = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxProdutos = new System.Windows.Forms.ComboBox();
            this.buttonProcurarImg = new System.Windows.Forms.Button();
            this.txttituloAt = new System.Windows.Forms.TextBox();
            this.txtpathAt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.txtdescricaoAt = new System.Windows.Forms.TextBox();
            this.txtprecoAt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtestoqueAt = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupCadastrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduto)).BeginInit();
            this.groupAtualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.ReadOnlyChecked = true;
            this.ofd.ShowReadOnly = true;
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.AutoSize = false;
            this.cadastrarToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.cadastrarToolStripMenuItem.Checked = true;
            this.cadastrarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cadastrarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cadastrarToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, -8);
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cadastrarToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // atualizarEstoqueToolStripMenuItem
            // 
            this.atualizarEstoqueToolStripMenuItem.AutoSize = false;
            this.atualizarEstoqueToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, -8);
            this.atualizarEstoqueToolStripMenuItem.Name = "atualizarEstoqueToolStripMenuItem";
            this.atualizarEstoqueToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.atualizarEstoqueToolStripMenuItem.Text = "Atualizar Estoque";
            this.atualizarEstoqueToolStripMenuItem.Click += new System.EventHandler(this.atualizarEstoqueToolStripMenuItem_Click);
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.AutoSize = false;
            this.voltarToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.voltarToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, -8);
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.voltarToolStripMenuItem.Text = "Home";
            this.voltarToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem,
            this.cadastrarToolStripMenuItem,
            this.atualizarEstoqueToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(480, 25);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menu";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 21);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // groupCadastrar
            // 
            this.groupCadastrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupCadastrar.BackColor = System.Drawing.Color.White;
            this.groupCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupCadastrar.Controls.Add(this.buttonprocurar);
            this.groupCadastrar.Controls.Add(this.txttitulo);
            this.groupCadastrar.Controls.Add(this.txtpath);
            this.groupCadastrar.Controls.Add(this.label6);
            this.groupCadastrar.Controls.Add(this.buttoncadastrar);
            this.groupCadastrar.Controls.Add(this.txtdescricao);
            this.groupCadastrar.Controls.Add(this.txtpreco);
            this.groupCadastrar.Controls.Add(this.radiolancamento);
            this.groupCadastrar.Controls.Add(this.label7);
            this.groupCadastrar.Controls.Add(this.pictureProduto);
            this.groupCadastrar.Controls.Add(this.label8);
            this.groupCadastrar.Controls.Add(this.label9);
            this.groupCadastrar.Controls.Add(this.label10);
            this.groupCadastrar.Controls.Add(this.txtestoque);
            this.groupCadastrar.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupCadastrar.Location = new System.Drawing.Point(0, 19);
            this.groupCadastrar.Margin = new System.Windows.Forms.Padding(0);
            this.groupCadastrar.Name = "groupCadastrar";
            this.groupCadastrar.Size = new System.Drawing.Size(484, 325);
            this.groupCadastrar.TabIndex = 17;
            this.groupCadastrar.TabStop = false;
            this.groupCadastrar.Visible = false;
            // 
            // buttonprocurar
            // 
            this.buttonprocurar.Location = new System.Drawing.Point(335, 37);
            this.buttonprocurar.Name = "buttonprocurar";
            this.buttonprocurar.Size = new System.Drawing.Size(100, 24);
            this.buttonprocurar.TabIndex = 26;
            this.buttonprocurar.Text = "Procurar imagem";
            this.buttonprocurar.UseVisualStyleBackColor = true;
            this.buttonprocurar.Click += new System.EventHandler(this.buttonprocurar_Click);
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(213, 77);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(100, 20);
            this.txttitulo.TabIndex = 18;
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(213, 40);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(100, 20);
            this.txtpath.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Path";
            // 
            // buttoncadastrar
            // 
            this.buttoncadastrar.Location = new System.Drawing.Point(175, 267);
            this.buttoncadastrar.Name = "buttoncadastrar";
            this.buttoncadastrar.Size = new System.Drawing.Size(138, 33);
            this.buttoncadastrar.TabIndex = 14;
            this.buttoncadastrar.Text = "Cadastrar";
            this.buttoncadastrar.UseVisualStyleBackColor = true;
            this.buttoncadastrar.Click += new System.EventHandler(this.buttoncadastrar_Click);
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(213, 113);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(100, 20);
            this.txtdescricao.TabIndex = 20;
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(213, 152);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(100, 20);
            this.txtpreco.TabIndex = 22;
            // 
            // radiolancamento
            // 
            this.radiolancamento.AutoSize = true;
            this.radiolancamento.Location = new System.Drawing.Point(145, 225);
            this.radiolancamento.Name = "radiolancamento";
            this.radiolancamento.Size = new System.Drawing.Size(84, 17);
            this.radiolancamento.TabIndex = 25;
            this.radiolancamento.TabStop = true;
            this.radiolancamento.Text = "Lançamento";
            this.radiolancamento.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Titulo";
            // 
            // pictureProduto
            // 
            this.pictureProduto.BackColor = System.Drawing.Color.White;
            this.pictureProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureProduto.Location = new System.Drawing.Point(12, 19);
            this.pictureProduto.Name = "pictureProduto";
            this.pictureProduto.Size = new System.Drawing.Size(100, 114);
            this.pictureProduto.TabIndex = 27;
            this.pictureProduto.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Descrição";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(142, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Estoque";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(144, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Preço";
            // 
            // txtestoque
            // 
            this.txtestoque.Location = new System.Drawing.Point(213, 187);
            this.txtestoque.Name = "txtestoque";
            this.txtestoque.Size = new System.Drawing.Size(100, 20);
            this.txtestoque.TabIndex = 24;
            // 
            // groupAtualizar
            // 
            this.groupAtualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupAtualizar.BackColor = System.Drawing.Color.White;
            this.groupAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupAtualizar.Controls.Add(this.radioButton1);
            this.groupAtualizar.Controls.Add(this.label11);
            this.groupAtualizar.Controls.Add(this.comboBoxProdutos);
            this.groupAtualizar.Controls.Add(this.buttonProcurarImg);
            this.groupAtualizar.Controls.Add(this.txttituloAt);
            this.groupAtualizar.Controls.Add(this.txtpathAt);
            this.groupAtualizar.Controls.Add(this.label1);
            this.groupAtualizar.Controls.Add(this.buttonAtualizar);
            this.groupAtualizar.Controls.Add(this.txtdescricaoAt);
            this.groupAtualizar.Controls.Add(this.txtprecoAt);
            this.groupAtualizar.Controls.Add(this.label2);
            this.groupAtualizar.Controls.Add(this.pictureBox1);
            this.groupAtualizar.Controls.Add(this.label3);
            this.groupAtualizar.Controls.Add(this.label4);
            this.groupAtualizar.Controls.Add(this.label5);
            this.groupAtualizar.Controls.Add(this.txtestoqueAt);
            this.groupAtualizar.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupAtualizar.Location = new System.Drawing.Point(0, 19);
            this.groupAtualizar.Margin = new System.Windows.Forms.Padding(0);
            this.groupAtualizar.Name = "groupAtualizar";
            this.groupAtualizar.Size = new System.Drawing.Size(481, 325);
            this.groupAtualizar.TabIndex = 28;
            this.groupAtualizar.TabStop = false;
            this.groupAtualizar.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(160, 250);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 17);
            this.radioButton1.TabIndex = 28;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Lançamento";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Escolha um produto para atualizar";
            // 
            // comboBoxProdutos
            // 
            this.comboBoxProdutos.FormattingEnabled = true;
            this.comboBoxProdutos.Items.AddRange(new object[] {
            "Selecione.."});
            this.comboBoxProdutos.Location = new System.Drawing.Point(205, 16);
            this.comboBoxProdutos.Name = "comboBoxProdutos";
            this.comboBoxProdutos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProdutos.TabIndex = 28;
            this.comboBoxProdutos.SelectedIndexChanged += new System.EventHandler(this.comboBoxProdutos_SelectedIndexChanged);
            // 
            // buttonProcurarImg
            // 
            this.buttonProcurarImg.Location = new System.Drawing.Point(350, 69);
            this.buttonProcurarImg.Name = "buttonProcurarImg";
            this.buttonProcurarImg.Size = new System.Drawing.Size(100, 24);
            this.buttonProcurarImg.TabIndex = 26;
            this.buttonProcurarImg.Text = "Procurar imagem";
            this.buttonProcurarImg.UseVisualStyleBackColor = true;
            this.buttonProcurarImg.Click += new System.EventHandler(this.buttonProcurarImg_Click);
            // 
            // txttituloAt
            // 
            this.txttituloAt.Location = new System.Drawing.Point(228, 109);
            this.txttituloAt.Name = "txttituloAt";
            this.txttituloAt.Size = new System.Drawing.Size(100, 20);
            this.txttituloAt.TabIndex = 18;
            // 
            // txtpathAt
            // 
            this.txtpathAt.Location = new System.Drawing.Point(228, 72);
            this.txtpathAt.Name = "txtpathAt";
            this.txtpathAt.Size = new System.Drawing.Size(100, 20);
            this.txtpathAt.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Path";
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(190, 279);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(138, 33);
            this.buttonAtualizar.TabIndex = 14;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // txtdescricaoAt
            // 
            this.txtdescricaoAt.Location = new System.Drawing.Point(228, 145);
            this.txtdescricaoAt.Name = "txtdescricaoAt";
            this.txtdescricaoAt.Size = new System.Drawing.Size(100, 20);
            this.txtdescricaoAt.TabIndex = 20;
            // 
            // txtprecoAt
            // 
            this.txtprecoAt.Location = new System.Drawing.Point(228, 184);
            this.txtprecoAt.Name = "txtprecoAt";
            this.txtprecoAt.Size = new System.Drawing.Size(100, 20);
            this.txtprecoAt.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Titulo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(28, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 114);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Estoque";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Preço";
            // 
            // txtestoqueAt
            // 
            this.txtestoqueAt.Location = new System.Drawing.Point(228, 219);
            this.txtestoqueAt.Name = "txtestoqueAt";
            this.txtestoqueAt.Size = new System.Drawing.Size(100, 20);
            this.txtestoqueAt.TabIndex = 24;
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(480, 343);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupAtualizar);
            this.Controls.Add(this.groupCadastrar);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CadastroProduto";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CadastroProduto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupCadastrar.ResumeLayout(false);
            this.groupCadastrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduto)).EndInit();
            this.groupAtualizar.ResumeLayout(false);
            this.groupAtualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupCadastrar;
        private System.Windows.Forms.Button buttonprocurar;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttoncadastrar;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.RadioButton radiolancamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureProduto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtestoque;
        private System.Windows.Forms.GroupBox groupAtualizar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxProdutos;
        private System.Windows.Forms.Button buttonProcurarImg;
        private System.Windows.Forms.TextBox txttituloAt;
        private System.Windows.Forms.TextBox txtpathAt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.TextBox txtdescricaoAt;
        private System.Windows.Forms.TextBox txtprecoAt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtestoqueAt;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}