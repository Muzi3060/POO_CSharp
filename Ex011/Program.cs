using Ex011;

List<Funcionario> funcionarios = new List<Funcionario>()
{
    new Horista("Alice", 20, 160),
    new Horista("Bob", 25, 140),
    new Mensalista("Charlie", 3000),
    new Mensalista("David", 3500)
};

foreach (var funcionario in funcionarios)
{
    funcionario.AnalisarSalario();
}