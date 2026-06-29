namespace exercicio1POOCsharp
{
    class ContaBancaria
    {
        public int Indicador { get; set; }
        public string Titular { get; set; }
        public string Senha { get; set; }
        public double Saldo { get; set; }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Indicador: {Indicador}");
            Console.WriteLine($"Titular: {Titular}");
            Console.WriteLine($"Saldo: {Saldo}");
            Console.WriteLine($"Senha: {Senha}");
        }
    }
}
