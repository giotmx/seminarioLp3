using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_aquila
{
    public class FreteNormal : DecoratorProdutoFrete
    {
        public FreteNormal(e_Produto p) : base(p)
        {
            base.preco = 40.00;
        }

    }
}
