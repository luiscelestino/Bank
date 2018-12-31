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
    public partial class Form1 : Form
    {
        // atributes
        private List<Conta> contas;
        private Dictionary<string, Conta> dicionario; // para implementar a busca de contas

        public Form1()
        {
            InitializeComponent();
        }

        public void AdicionaConta(Conta conta)
        {
            // adiciona conta
            this.contas.Add(conta);

            // atualiza dicionario
            this.dicionario.Add(conta.Titular.Nome, conta);

            // atualiza combobox
            comboIndice.Items.Add(conta);
            comboDestinoTransferencia.Items.Add(conta);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Idade = 40;

            MessageBox.Show("idade = " + cliente.Idade);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.contas = new List<Conta>();
            this.dicionario = new Dictionary<string, Conta>();

            Conta c1 = new ContaPoupanca()
            {
                Titular = new Cliente("Agenor"),
                Numero = 1
            };
            Conta c2 = new ContaPoupanca()
            {
                Titular = new Cliente("Allan"),
                Numero = 2
            };
            Conta c3 = new ContaCorrente()
            {
                Titular = new Cliente("Leo"),
                Numero = 3
            };

            this.AdicionaConta(c1);
            this.AdicionaConta(c2);
            this.AdicionaConta(c3);
        }

        private void botaoDepositar_Click(object sender, EventArgs e)
        {
            Conta contaSelecionada = (Conta) comboIndice.SelectedItem;
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);

            try
            {
                contaSelecionada.Deposita(valorOperacao);
                textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show("Argumento Inválido");
            }
        }

        private void botaoSacar_Click(object sender, EventArgs e)
        {
            Conta contaSelecionada = (Conta) comboIndice.SelectedItem;

            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);

            contaSelecionada.Saca(valorOperacao);
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
        }

        private void comboIndice_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conta contaSelecionada = (Conta) comboIndice.SelectedItem;

            textoTitular.Text = contaSelecionada.Titular.Nome;
            textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
        }

        private void botaoTransferir_Click(object sender, EventArgs e)
        {
            Conta contaOrigem = (Conta) comboIndice.SelectedItem;
            Conta contaDestino = (Conta) comboDestinoTransferencia.SelectedItem;
            double valor = Convert.ToDouble(textoValor.Text);

            if( !contaOrigem.Equals(contaDestino) && contaOrigem.Saca(valor) )
            {
                contaDestino.Deposita(valor);
                textoSaldo.Text = Convert.ToString(contaOrigem.Saldo);
            }
        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formCadastroConta = new FormCadastroConta(this);
            formCadastroConta.ShowDialog();
        }

        private void botaoCalcularTributos_Click(object sender, EventArgs e)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Deposita(200.0);
            MessageBox.Show( "imposto da conta corrente = " + conta.CalculaTributos() );

            ITributavel t = conta;
            MessageBox.Show( "imposto da conta pela interface = " + t.CalculaTributos() );

            SeguroDeVida sv = new SeguroDeVida();
            MessageBox.Show( "imposto do seguro = " + sv.CalculaTributos() );

            t = sv;
            MessageBox.Show( "imposto do seguro pela interface = " + t.CalculaTributos() );
        }

        private void botaoBuscar_Click(object sender, EventArgs e)
        {
            string nomeTitular = textoBuscarTitular.Text;

            try
            {
                Conta conta = dicionario[nomeTitular];

                // atualiza campos com as informações da conta
                textoTitular.Text = conta.Titular.Nome;
                textoNumero.Text = Convert.ToString(conta.Numero);
                textoSaldo.Text = Convert.ToString(conta.Saldo);
                comboIndice.SelectedItem = conta;
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show("Conta inexistente");
            }
        }

        private void botaoRelatorios_Click(object sender, EventArgs e)
        {
            FormRelatorios formRelatorios = new FormRelatorios(this.contas);
            formRelatorios.ShowDialog();
        }
    }
}
