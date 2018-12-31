using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Cliente
    {
        // properties
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public int Idade { get; set; }

        // constructors
        public Cliente() { }

        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        // methods
        public bool ehMaiorDeIdade()
        {
            return this.Idade >= 18;
        }
    }
}
