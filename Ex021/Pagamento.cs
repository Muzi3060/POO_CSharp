namespace Ex021;

public abstract class Pagamento(decimal valor)
{
    private decimal Valor { get; init; } = valor;
    
    public void Pagar() => Console.WriteLine($"Pagamento de {Valor:C} realizado com sucesso! Através da modalidade ({GetType().Name}).");
    
}
internal class Boleto(decimal valor) : Pagamento(valor) {}

internal class Pix(decimal valor) : Pagamento(valor) {}

internal class Credito(decimal valor) : Pagamento(valor) {}