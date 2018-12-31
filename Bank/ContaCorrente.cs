using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Contas
{
    class ContaCorrente : Conta, ITributavel
    {
        public override bool Saca(double valor)
        {
            bool saqueRealizado = false;

            valor += 0.05;

            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
                saqueRealizado = true;
            }

            return saqueRealizado;
        }

        public override void Deposita(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException();
            }
            else
            {
                this.Saldo += valor;
            }
        }

        public double CalculaTributos()
        {
            return this.Saldo * 0.05;
        }
    }
}
