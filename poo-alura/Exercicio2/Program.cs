using exercicio1POOCsharp;

// questao 2
ContaBancaria conta = new ContaBancaria();
conta.Titular = "Pedro";
conta.Senha = "12314";
conta.Indicador = 12;
conta.Saldo = 1200;

Console.WriteLine($"Titular: {conta.Titular}");
Console.WriteLine($"Saldo: {conta.Saldo}");

// questao 3
conta.ExibirInformacoes();
