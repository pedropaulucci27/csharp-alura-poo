class Podcast
{
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios { get; set; }
    private List<Episodio> episodios = new();

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
        TotalEpisodios++;
        Console.WriteLine($"Episodio {episodio.Titulo} adicionado com sucesso!");
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Host: {Host} - Nome: {Nome} - Total de episódios: {TotalEpisodios}");
        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
    }
}
