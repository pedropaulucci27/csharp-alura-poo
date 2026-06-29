using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    internal class Pedido
    {
        public List<Item> Itens { get; set; } = new List<Item>();
        public Mesa Mesa { get; set; }
    }
}
