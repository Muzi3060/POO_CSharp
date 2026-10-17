using System.Runtime.Intrinsics.Arm;

namespace Ex011;

public abstract class Funcionario
{
    public string Nome { get; set; } 
    public float SalarioBruto { get; set; } = 0f;
    public static short SalarioMinimo { get; set; } = 1612;
    public static float Inss { get; set; } = 0.075f;

    protected Funcionario(string nome, float salarioBruto)
    {
        Nome = nome;
        SalarioBruto = salarioBruto;
    }
    
    protected abstract float CalcularSalarioLiquido();

    public void AnalisarSalario()
    {
        Console.WriteLine($"O salário líquido do funcionário {Nome} que é um {GetType().Name} é: {CalcularSalarioLiquido():C2}");
        // não precisamos do this aqui para usar o GetType().Name, pois o método AnalisarSalario() é chamado a partir de uma instância da classe filha (Horista ou Mensalista), e o GetType() retorna o tipo real do objeto em tempo de execução. Portanto, ele já sabe que é um Horista ou Mensalista, e não precisamos especificar isso com o this.
    }
}

class Horista : Funcionario
{
    public short ValorHora { get; set; } = 0;
    public short HorasTrabalhadas { get; set; } = 0;

    public Horista(string nome, short valorHora, short horasTrabalhadas) : base(nome, 0f)
    {
        ValorHora = valorHora;
        HorasTrabalhadas = horasTrabalhadas;
    }

    protected override float CalcularSalarioLiquido()
    {
        SalarioBruto = ValorHora * HorasTrabalhadas;
        float salarioLiquido = SalarioBruto - (SalarioBruto * Inss);
        return salarioLiquido;
    }
}

class Mensalista : Funcionario
{
    public Mensalista(string nome, float salarioBruto) : base(nome, salarioBruto)
    {
    }

    protected override float CalcularSalarioLiquido()
    {
        float salarioLiquido = SalarioBruto - (SalarioBruto * Inss);
        return salarioLiquido;
    }
}