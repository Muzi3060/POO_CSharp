namespace Ex003;

public class Churrasco
{
    public int quantidadePessoas { get; private set; }
    public string Titulo { get; private set; }

    public Churrasco(int qtdPessoas, string titulo)
    {
        quantidadePessoas = qtdPessoas;
        Titulo = titulo;

        Detalhes();
    }
    
    
    // Consumo padrão 400g por pessoa
    // Preço da carne R$ 82.40/kg

    public double CalcularCarne()
    {
        return quantidadePessoas * 0.4;
    }

    public double CalcularCustoTotal()
    {
        return CalcularCarne() * 82.4;
    }

    public double CalcularPrecoPorPessoa()
    {
        return CalcularCustoTotal() / quantidadePessoas;
    }

    public void Detalhes()
    {
        Console.WriteLine($"Analisando o {Titulo}, com {quantidadePessoas} convidados. \n" +
                          $"Cada participante comerá 0.4kg e cada KG custará R$82.40. \n" +
                          $"Recomendo comprar {CalcularCarne()}Kg de carne. \n" +
                          $"O custo total será de R${CalcularCustoTotal()} \n" +
                          $"Cada pessoa pagará R${CalcularPrecoPorPessoa()} para participar.");
    }
}