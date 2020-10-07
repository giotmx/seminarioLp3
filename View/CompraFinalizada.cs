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
    public partial class CompraFinalizada : Form
    {
        string[] controle;
        double precoT;
        public CompraFinalizada(double preco, string[] c)
        {
            InitializeComponent();
            controle = c;
            precoT = preco;
            calculaValor();
        }

        public void calculaValor()
        {
            double val;
            Usuario usu = new Usuario(controle[2], precoT);
            val = usu.CalcularDesconto();
            MessageBox.Show(val.ToString());
            
        }

        private void CompraFinalizada_Load(object sender, EventArgs e)
        {

        }
    }
}
