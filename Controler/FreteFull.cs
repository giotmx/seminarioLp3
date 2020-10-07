using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_aquila
{
    public class FreteFull : DecoratorProdutoFrete
    {
        public FreteFull(e_Produto p) : base(p)
        {
            base.preco = 80.00;
        }
    }
}
