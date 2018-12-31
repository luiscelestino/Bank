using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Contas;

namespace Bank
{
    class TotalizadorDeContas
    {
        // properties
        public double SaldoTotal { get; set; }

        // methods
        public void Adiciona(Conta conta)
        {
            this.SaldoTotal += conta.Saldo;
        }

        // testa TotalizadorDeContas
        public void testaTotalizador()
        {
            Conta c1 = new ContaPoupanca();
            c1.Saldo = 10;

            Conta c2 = new ContaCorrente();
            c2.Saldo = 20;

            Conta c3 = new ContaPoupanca();
            c3.Saldo = 30;

            this.Adiciona(c1);
            this.Adiciona(c2);
            this.Adiciona(c3);

            System.Windows.Forms.MessageBox.Show("Saldo Total = " + this.SaldoTotal);
        }

    }
}
