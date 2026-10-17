namespace Ex010;

public abstract class Transporte
{
    public short Distancia { get; set; } = 0;
    public short Frete { get; set; } = 0;
    
    protected Transporte(short distancia)
    {
        Distancia = distancia;
    }
    
    public abstract void CalcularFrete();
}

class Moto : Transporte
{
    private static readonly float fator = 0.50f;

    public Moto(short distancia) : base(distancia)
    {
    }

    public override void CalcularFrete()
    {
        Frete = (short)(Distancia * fator);
    }
}

class Caminhao : Transporte
{
    private static readonly float fator = 1.20f;

    public Caminhao(short distancia) : base(distancia)
    {
    }

    public override void CalcularFrete()
    {
        if (Distancia >= 50) {
            Frete = (short)(Distancia * fator);
        }else {
            Console.WriteLine("Caminhões não podem transportar cargas em distâncias menores que 50 km.");
        }
    }
}

class Drone : Transporte
{
    private static readonly float fator = 9.50f;

    
    // aqui o readonly é usado para que o valor do fator não possa ser alterado em tempo de execução, garantindo que o cálculo do frete seja consistente e previsível.
    
    // readonly é o mesmo que o final em Java, ou seja, uma vez atribuído, o valor não pode ser alterado.
    
    public Drone(short distancia) : base(distancia)
    {
    }

    public override void CalcularFrete()
    {
        if (Distancia <= 10) {
            Frete = (short)(Distancia * fator);
        }else {
            Console.WriteLine("Drones não podem voar em distâncias maiores que 10 km.");
        }
    }
}

