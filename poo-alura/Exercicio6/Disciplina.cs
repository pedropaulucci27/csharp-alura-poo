using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    internal class Disciplina
    {
        public string Nome { get; set; }
        public List<Aluno> Alunos { get; set; } = new List<Aluno>();
    }
}
