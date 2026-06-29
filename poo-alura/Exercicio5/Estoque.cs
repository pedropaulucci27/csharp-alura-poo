using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class Estoque
    {
        private List<Produto> produtos = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
            Console.WriteLine($"Produto {produto.Nome} adicionado com sucesso");
        }

        public void ExibirProdutos()
        {
            if (produtos.Count == 0)
            {
                Console.WriteLine("Estoque vazio.");
                return;
            }

            Console.WriteLine("Produtos disponíveis no estoque: ");
            foreach (Produto produto in produtos)
            {
                Console.WriteLine(produto.Nome);
            }
        }
    }
}
