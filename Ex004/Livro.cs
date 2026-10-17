namespace Ex004;

public class Livro
{
    public string Titulo { get; set; }
    public int TotalPaginas { get; set; }
    public int PaginaAtual { get; private set; }

    public Livro(string titulo, int totalPaginas)
    {
        Titulo = titulo;
        TotalPaginas = totalPaginas;
        PaginaAtual = 1;
    }

    public void AvancarPagina()
    {
        if (PaginaAtual < TotalPaginas)
        {
            PaginaAtual++;
        }
    }

    public bool VerificarFim()
    {
        if (PaginaAtual == TotalPaginas)
        {
            Console.WriteLine($"Você está na pagina {PaginaAtual}");
            Console.WriteLine($"Você chegou ao fim do livro ({Titulo}).");
            return true;
        }
        return false;
    }
}