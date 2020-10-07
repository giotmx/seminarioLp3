using e_aquila.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_aquila
{
    public class FamiliaProdutos : Produto
    {
		protected List<Produto> prod;

		public FamiliaProdutos()
		{
			prod = new List<Produto>();
		}

		public void adicionarProduto(Produto newProd)
		{
			this.prod.Add(newProd);
		}

		public void removerProduto(String nome)
		{
			foreach (Produto p in prod)
			{
				if (p.Titulo == nome)
				{
					this.prod.Remove(p);
					return;
				}
			}
			MessageBox.Show("Esta produto não existe na familia!");
		}

		public List<Produto> retornaLista()
		{
			return this.prod;
		}

	}
}
