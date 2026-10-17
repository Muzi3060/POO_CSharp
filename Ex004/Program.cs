using Ex004;

Livro livro = new Livro("Dom casmurra", 25);


while (!livro.VerificarFim())
{
    Console.WriteLine($"Pagina atual: {livro.PaginaAtual}");
    livro.AvancarPagina();
} 