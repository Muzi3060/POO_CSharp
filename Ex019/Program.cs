using Ex019;

var funcionarios = new List<Funcionario>()
{
    new Gerente("João", 5000),
    new Desenvolvedor("Maria", 4000),
    new Designer("Pedro", 3000)
};

foreach (var funcionario in funcionarios)
{
    funcionario.CalcularBonus();
}