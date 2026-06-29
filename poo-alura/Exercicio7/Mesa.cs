using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    internal class Mesa
    {
        public int Numero { get; set; }
        public List<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}
