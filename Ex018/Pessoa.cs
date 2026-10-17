namespace Ex018;

public abstract class Pessoa(string nome, short nascimento)
{
    protected string Nome { get; set; } = nome;
    protected short Nascimento { get; } = SetNascimento(nascimento);
    private static short SetNascimento(short nascimento) => nascimento < 1900 || nascimento > DateTime.Now.Year ? throw new Exception("Ano de nascimento inválido.") : nascimento;
}

class Aluno : Pessoa
{
    private readonly List<string> _cursosOficiais = new List<string>{ "ENG", "MED", "ADM", "ADS", "CC" };
    protected string Curso { get; }
    public Aluno(string nome, short nascimento, string curso) : base(nome, nascimento)
    {
        Curso = SetCurso(curso);
    }
    public string SetCurso(string curso) => !_cursosOficiais.Contains(curso.ToUpper()) ? throw new Exception("Curso não encontrado.") : $"Curso {curso} definido com sucesso!";
    public void AddCurso(string curso)
    {
        if (_cursosOficiais.Contains(curso.ToUpper()))
        {
            throw new Exception("Curso já cadastrado.");
        }
        _cursosOficiais.Add(curso.ToUpper());
        Console.WriteLine($"Curso {curso} adicionado com sucesso!");
    }
    
    public void MostrarCursos()
    {
        Console.WriteLine("Cursos disponíveis:");
        foreach (var curso in _cursosOficiais)
        {
            Console.WriteLine(curso);
        }
    }
}