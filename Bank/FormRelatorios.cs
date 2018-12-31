using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank.Contas;

namespace Bank
{
    public partial class FormRelatorios : Form
    {
        // atributes
        private List<Conta> contas;

        public FormRelatorios(List<Conta> contas)
        {
            InitializeComponent();
            this.contas = contas;
        }

        private void botaoFiltroSaldo5000_Click(object sender, EventArgs e)
        {
            listBoxResultado.Items.Clear();

            var resultado = from c in this.contas
                            where c.Saldo > 5000
                            orderby c.Titular.Nome
                            select c;

            foreach (var c in resultado)
            {
                listBoxResultado.Items.Add(c);
            }

            // calcula resumo
            double saldoTotal = resultado.Sum(conta => conta.Saldo);
            double maiorSaldo = resultado.Max(conta => conta.Saldo);

            // exibe resumo
            labelValorSaldoTotal.Text = Convert.ToString(saldoTotal);
            labelValorMaiorSaldo.Text = Convert.ToString(maiorSaldo);
        }

        private void botaoAntigas_Click(object sender, EventArgs e)
        {
            listBoxResultado.Items.Clear();

            var resultado = from c in this.contas
                            where c.Saldo > 1000 && c.Numero < 10
                            orderby c.Titular.Nome
                            select c;

            foreach (var c in resultado)
            {
                listBoxResultado.Items.Add(c);
            }

            // calcula resumo
            double saldoTotal = resultado.Sum(conta => conta.Saldo);
            double maiorSaldo = resultado.Max(conta => conta.Saldo);

            // exibe resumo
            labelValorSaldoTotal.Text = Convert.ToString(saldoTotal);
            labelValorMaiorSaldo.Text = Convert.ToString(maiorSaldo);
        }
    }
}
