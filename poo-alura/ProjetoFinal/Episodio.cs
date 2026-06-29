class Episodio
{
    private List<string> convidados = new();

    public Episodio(double duracao, string titulo, int ordem)
    {
        Duracao = duracao;
        Titulo = titulo;
        Ordem = ordem;
    }

    public double Duracao { get; }
    public string Titulo { get; }
    public int Ordem { get; }

    public string Resumo => $"Ordem: {Ordem} - Título: {Titulo} - Duração: {Duracao}min - {string.Join(", ", convidados)}";

    public void AdicionarConvidado(string convidado)
    {
        convidados.Add(convidado);
        Console.WriteLine($"Convidado {convidado} adicionado com sucesso!");
    }
}
