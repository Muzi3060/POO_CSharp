namespace Ex005;

public class Gamer
{
    public string Nome { get; set; }
    public string Nick { get; set; }
    private List<string> JogosFavoritos { get; set; }

    public Gamer(string nome, string nick)
    {
        Nome = nome;
        Nick = nick;
        JogosFavoritos = new List<string>();
    }


    public void adicionarJogosFavoritos(string jogo)
    {
        if (!JogosFavoritos.Contains(jogo)) // Verifica se o jogo já está na lista de favoritos
        {
            Console.WriteLine($"Jogo '{jogo}' adicionado aos favoritos.");
            JogosFavoritos.Add(jogo);
        }else
        {
            Console.WriteLine($"Jogo '{jogo}' já está nos favoritos.");
        }
    }
    
    public void mostrarFicha()
    {
        if (JogosFavoritos is null || JogosFavoritos.Count == 0) { // Verifica se a lista de jogos favoritos está vazia
            Console.WriteLine($"Nenhum jogo favorito adicionado do usuario {Nick}");
            return;
        }
        
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Nick: {Nick}");
        Console.WriteLine("Jogos Favoritos: ");

        foreach (var jogo in JogosFavoritos)
        {
            Console.WriteLine($"- {jogo}");
        }
        
    }
}