using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_aquila
{
    public class Usuario
    {
        public string cpf { get; set; }
        public string nome { get; set; }
        public string user { get; set; }
        public string senha { get; set; }
        public string status { get; set; }
        public string tipo { get; set; }

        public double totalGasto { get;  set; }

        private IDesconto DescontoStrategy;


        public Usuario() { }

        public Usuario(string tipo, double val)
        {
            this.status = tipo;
            this.totalGasto = val;
            if (this.status == "new")
            {
                this.DescontoStrategy = new DescontoNormal();
            }
            else
            {
                this.DescontoStrategy = new DescontoEspecial();
            }
            
        }
        public double CalcularDesconto()
        {
            return this.DescontoStrategy.Calcular(this.totalGasto);
        }
    }
}

