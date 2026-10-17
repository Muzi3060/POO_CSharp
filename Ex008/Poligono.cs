namespace Ex008;

// classe abastrata
public abstract class Poligono
{
    protected double QtdLados { get; set; }
    
    protected Poligono(double qtdLados)
    {
        QtdLados = qtdLados;
    }

    protected abstract double perimetro();

    protected abstract double area();

    public virtual void resultado()
    {
        Console.WriteLine("Resultados:");
        Console.WriteLine($"Perímetro: {perimetro()}");
        Console.WriteLine($"Área: {area()}");
    }
    
}

// classe filha
class Quadrado : Poligono
{
    private double Lado { get; set; }

    public Quadrado(double lado) : base(4) 
    {
        Lado = lado;
    }
    
    protected override double perimetro()
    {
        return Lado * QtdLados;
    }
    
    protected override double area()
    {
        return Lado * Lado;
    }
}

// classe filha
class Circulo : Poligono
{
    private double Raio { get; set; }
    
    public Circulo(double raio) : base(0){
        Raio = raio;
    }

    protected override double perimetro()
    {
        return 2 * Math.PI * Raio;
    }

    protected override double area()
    {
        return Math.PI * Raio * Raio;
    }
    
}