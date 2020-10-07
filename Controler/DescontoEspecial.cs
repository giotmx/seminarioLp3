using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_aquila
{
    public class DescontoEspecial : IDesconto
    {
        public double Calcular(double valorDaCompra)
        {
            return valorDaCompra - (valorDaCompra * 0.10);
        }
        
    }
}
