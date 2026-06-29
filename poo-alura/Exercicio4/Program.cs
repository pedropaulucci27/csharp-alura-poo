using ConsoleApp3;

Conta conta1 = new Conta();
Titular titular1 = new Titular();

conta1.Titular = titular1;

titular1.Nome = "Pedro";
titular1.Cpf = "123134";
titular1.Endereco = "Rua paracatu 1450";

Console.WriteLine(conta1.Titular.informacoes);
