using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    internal class Restaurante
    {
        public List<Mesa> Mesas { get; set; } = new List<Mesa>();
        public Cardapio Cardapio { get; set; } = new Cardapio();
    }
}
