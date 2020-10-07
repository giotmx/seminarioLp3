using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_aquila
{
    public abstract class DecoratorProdutoFrete : e_Produto
    {
        e_Produto p;

        public DecoratorProdutoFrete(e_Produto p1)
        {
            p = p1;
        }

        public override double getPreco()
        {
            return p.getPreco() + preco;
        }
    }
}
