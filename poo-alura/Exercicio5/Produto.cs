using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class Produto
    {
        private double preco;
        private int quantidade;

        public string Nome { get; set; }

        public double Preco
        {
            get => preco;
            set
            {
                if (value <= 0)
                    preco = 10;
                else
                    preco = value;
            }
        }

        public int Quantidade
        {
            get => quantidade;
            set
            {
                if (value <= 0)
                    quantidade = 0;
                else
                    quantidade = value;
            }
        }
    }
}
