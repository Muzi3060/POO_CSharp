namespace Ex019;

public abstract class Funcionario(string nome, float salario)
{
    private string Nome { get; set; } = nome;
    protected float Salario { get; set; } = salario;

    public abstract void CalcularBonus();
    protected void ExibirMensagem(float bonus) => Console.WriteLine($"O bônus do {GetType().Name} {Nome} é: {bonus}");
}

internal class Gerente(string nome, float salario) : Funcionario(nome, salario)
{
    public override void CalcularBonus() => ExibirMensagem(Salario * 0.15f);
}

internal class Desenvolvedor(string nome, float salario) : Funcionario(nome, salario)
{
    public override void CalcularBonus() => ExibirMensagem(Salario * 0.10f);   
}

internal class Designer(string nome, float salario) : Funcionario(nome, salario)
{
    public override void CalcularBonus() => ExibirMensagem(Salario * 0.08f);
}
