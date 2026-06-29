public class Produto
{
    public string Nome { get; set; }
    public string Marca { get; set; }

    private double preco; // corrigido: campo privado simples, sem { get; set; }
    private int estoque;

    public string DetalhaProduto => $"Nome: {Nome} - Marca: {Marca} - Estoque: {estoque} - Preço: {preco}";

    public double Preco
    {
        get => preco;
        set
        {
            if (value > 0)
            {
                preco = value;
            }
            else
            {
                preco = 10;
            }
        }
    }

    public int Estoque
    {
        get => estoque;
        set
        {
            if (value >= 0)
            {
                estoque = value;
            }
            else
            {
                estoque = 0;
            }
        }
    }
}
