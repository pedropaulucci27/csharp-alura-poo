using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Conta
    {
        public Titular Titular { get; set; }
        public string Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }

        public string informacoes => $"Titular: {Titular.Nome} - Número: {Numero} - Saldo: {Saldo} - Limite: {Limite} - Agência: {Agencia}";
    }
}
