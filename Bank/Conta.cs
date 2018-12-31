using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Contas
{
    public abstract class Conta
    {
        // properties
        public double Saldo { get; set; }
        public Cliente Titular { get; set; }
        public int Numero { get; set; }

        // methods
        public abstract void Deposita(double valor);

        public abstract bool Saca(double valor);

        public void Transfere(Conta destino, double valor)
        {
            if( this.Saca(valor) )
            {
                destino.Deposita(valor);
            }            
        }

        public override string ToString()
        {
            return "titular: " + this.Titular.Nome;
        }
    }
}
