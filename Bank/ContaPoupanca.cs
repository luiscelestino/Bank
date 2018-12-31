using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Contas
{
    class ContaPoupanca : Conta
    {
        public override bool Saca(double valor)
        {
            bool saqueRealizado = false;

            valor += 0.10;

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
}
}
