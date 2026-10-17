namespace Ex002;

public class Produto
{
    public string Nome { get; }
    public double Preco { get; }

    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;

        mostrarEtiqueta();
    }
    public void mostrarEtiqueta()
    {
        Console.WriteLine($"Produto: {Nome}, Preço: {Preco}");
    }

}