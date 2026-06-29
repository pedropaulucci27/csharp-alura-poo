using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    internal class Professor
    {
        public string Nome { get; set; }
        public List<Disciplina> Disciplinas { get; set; } = new();
    }
}
