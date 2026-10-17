namespace Ex001;

public class Funcionario
{
    
    // Criando os atributos da classe Funcionario, e seus getters e setters
    public string Nome { get; set; }
    public string Setor { get; set; }
    public string Cargo { get; set; }

    // Construtor da classe Funcionario
    public Funcionario(string nome, string setor, string cargo)
    {
        Nome = nome;
        Setor = setor;
        Cargo = cargo;
        
        // Chamando o método Apresentar() dentro do construtor
        Apresentar();
    }

    // Criando método apresentar, usando o getter de nome
    public void Apresentar()
    {
        Console.WriteLine($"Olá, Meu nome é {Nome}, sou do setor {Setor} e meu cargo é {Cargo}");
    }
}