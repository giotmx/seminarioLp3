using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_aquila
{
    public abstract class e_Produto
    {
        public double preco { get; set; }

        public virtual double getPreco()
        {
            return preco;
        }
    }
}
