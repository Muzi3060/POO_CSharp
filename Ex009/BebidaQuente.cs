namespace Ex009;

public abstract class BebidaQuente
{
    public void Preparar() {
        Console.WriteLine("--- Iniciando o Preparo ---");
        FerverAgua();
        Misturar();
        Servir();
    }
    
    protected void FerverAgua() {
        Console.WriteLine("1. Fervendo água a 100 graus Celsius.");
    }

    protected abstract void Misturar();

    protected abstract void Servir();
}

class Cafe : BebidaQuente
{
    
    protected override void Misturar()
    {
        Console.WriteLine("2. Passando água pressurizada pelo pó de café moido.");
    }

    protected override void Servir()
    {
        Console.WriteLine("3. Servindo em xicara pequena.");
    }
}

class Cha : BebidaQuente
{
    protected override void Misturar()
    {
        Console.WriteLine("2. Mergulhando o sachê de ervas na água.");
    }

    protected override void Servir()
    {
        Console.WriteLine("3. Servindo na caneca de porcelana com limão.");
    }
}

class Leite : BebidaQuente
{
    protected override void Misturar()
    {
        Console.WriteLine("2. Passando vapor pressurizado pelo bico do leite.");
    }

    protected override void Servir()
    {
        Console.WriteLine("3. Servindo na caneca grande, já com café.");
    }
}

