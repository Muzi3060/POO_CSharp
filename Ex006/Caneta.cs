namespace Ex006;

public class Caneta
{
    public string Cor { get; set; }
    public bool tampada { get; set; }

    public Caneta(string cor)
    {
        Cor = cor;
        tampada = true;
    }

    public string escrever(string texto)
    {
        if (tampada)
        {
            return "\u001b[31mA caneta está tampada. Não é possível escrever. \u001b[0m";
        }

        
        // Swtich de expressão para determinar o código de cor ANSI com base na cor da caneta
        string codigoCor = Cor.ToLower() switch
        {
            "azul" => "\u001b[34m",
            "vermelha" => "\u001b[31m",
            "verde" => "\u001b[32m",
            _ => "\u001b[0m"
        };
        
        return $"{codigoCor}{texto}\u001b[0m";

    }

    public void tampar()
    {
        tampada = true;
    }

    public void destampar()
    {
        tampada = false;
    }
}