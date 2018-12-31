using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank.Busca;
using Bank.Contas;

namespace Bank
{
    public partial class FormCadastroConta : Form
    {
        private ICollection<string> devedores;
        private Form1 formPrincipal;

        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();

            GeradorDeDevedores gerador = new GeradorDeDevedores();
            this.devedores = gerador.GeraList();
        }

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            ContaCorrente novaConta = new ContaCorrente()
            {
                Titular = new Cliente(textoTitular.Text),
                Numero = Convert.ToInt16(textoNumero.Text)
            };
            bool ehDevedor = false;

            ehDevedor = this.devedores.Contains(textoTitular.Text);

            if (!ehDevedor)
            {
                this.formPrincipal.AdicionaConta(novaConta);
            }
            else
            {
                MessageBox.Show("devedor");
            }
        }
    }
}
