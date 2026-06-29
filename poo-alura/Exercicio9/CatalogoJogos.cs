class CatalogoJogos
{
    private List<Jogo> Jogos { get; set; }

    public CatalogoJogos()
    {
        Jogos = new List<Jogo>();
    }

    public void AdicionarJogo(Jogo jogo)
    {
        Jogos.Add(jogo);
        Console.WriteLine($"Jogo {jogo.Nome} adicionado ao catálogo!");
    }

    public void ExibirJogos()
    {
        if (Jogos.Count == 0)
        {
            Console.WriteLine("Lista de jogos vazia!");
        }
        else
        {
            foreach (Jogo jogo in Jogos)
            {
                Console.WriteLine(jogo.Nome);
            }
        }
    }
}
