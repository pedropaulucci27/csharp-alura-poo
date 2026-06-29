using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Titular
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public string informacoes => $"Nome: {Nome} - Cpf: {Cpf} - Endereço: {Endereco}";
    }
}
