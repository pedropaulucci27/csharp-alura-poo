using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<double> Notas { get; set; } = new List<double>();
    }
}
