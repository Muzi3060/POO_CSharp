namespace Ex020;

public class Arquivo(string nome, float tamanho)
{
    private string Nome { get; set; } = nome;
    protected string Extensao { get; init; } = "";
    private float Tamanho { get; set; } = tamanho / 1000;
    public string Abrir() => $"Abrindo o arquivo {Nome}.{Extensao} de tamanho {Tamanho}MB";
}
internal class Pdf : Arquivo
{
    public Pdf(string nome, float tamanho) : base(nome, tamanho) => Extensao = "pdf";
    
}

internal class Doc : Arquivo
{
    public Doc(string nome, float tamanho) : base(nome, tamanho) => Extensao = "doc";
}