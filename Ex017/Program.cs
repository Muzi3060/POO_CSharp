using Ex017;


ContaBancaria conta = new ContaBancaria(1, "João", 1000.0f, "123");

try
{
    conta.Sacar(500, "123");
    Console.WriteLine(conta.ExibirSaldo("123"));
    Console.WriteLine("Saque realizado com sucesso.");
    conta.Depositar(1);
    Console.WriteLine(conta.ExibirSaldo("123"));
}
catch (Exception ex)
{
    Console.WriteLine($"Erro ao sacar: {ex.Message}");
}