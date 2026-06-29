public class Carro
{
    private int ano;

    public string Nome { get; set; }
    public string Fabricante { get; set; }
    public double Velocidade { get; set; }

    public int Ano
    {
        get => ano;
        set
        {
            if (value < 1960 || value > 2023)
            {
                Console.WriteLine("Valor inválido, insira um ano entre 1960 e 2023");
            }
            else
            {
                ano = value; // corrigido: campo privado (minúsculo)
            }
        }
    }

    public string DescricaoDetalhada => $"Fabricante {Fabricante} - Modelo: {Nome} - Ano: {Ano}";

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Velocidade: {Velocidade}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Fabricante: {Fabricante}");
    }

    public void Acelerar()
    {
        Console.WriteLine("Acelerado...");
        Velocidade += 10;
        Console.WriteLine($"Velocidade atual: {Velocidade}");
    }

    public void Frear()
    {
        Console.WriteLine("Freando...");
        Velocidade -= 10;
        Console.WriteLine($"Velocidade atual: {Velocidade}");
    }

    public void Buzinar()
    {
        Console.WriteLine("Bi Bi");
    }
}
