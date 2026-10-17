namespace Ex012;

public abstract class Personagem
{
    public string Nome { get; set; }
    public short Vida { get; set; }
    protected List<string> golpes = new List<string>(); // Lista de golpes do personagem, inicializando como uma lista vazia
    
    protected Personagem(string nome, short vida)
    {
        Nome = nome;
        Vida = vida;
    }
    
    public void Atacar(Personagem alvo, short forca) // Método para atacar outro personagem, recebendo o alvo e a força do ataque como parâmetros, sendo alvo do tipo Personagem.
    {
        short Dano = (short)Random.Shared.Next(100, forca + 1); // Gera um número aleatório entre 100 e a força do ataque, que será o dano causado ao alvo. Usamos um casting para short, pois o método Next retorna um int.
        alvo.ReceberDano(Dano);
        Console.WriteLine($"{Nome} atacou {alvo.Nome} com {golpes[Random.Shared.Next(0, golpes.Count)]} e deu {Dano} de dano."); // Exibe no console o nome do personagem que atacou, o nome do alvo, o golpe usado (escolhido aleatoriamente da lista de golpes) e o dano causado.
        
        // obs: Random.Shared é uma instância compartilhada de Random, que é mais eficiente do que criar uma nova instância a cada vez que precisamos gerar um número aleatório.
        // Aqui não precisamos fazer -1 depois do golpes.Count, pois o método Next já retorna um número aleatório entre 0 (inclusive) e o valor passado como parâmetro (exclusive).
    }
    
    public void ReceberDano(short dano)
    {
        Vida -= dano;
    }

    public abstract void curar();
}

class Guerreiro : Personagem
{
    public Guerreiro(string nome, short vida) : base(nome, vida)
    {
        golpes.Add("Golpe de espada");
        golpes.Add("Golpe de machado");
        golpes.Add("Golpe de lança");
        golpes.Add("Golpe de arco");
        golpes.Add("Golpe de martelo");
    }

    public override void curar()
    {
        short cura = (short)Random.Shared.Next(50, 151);
        Vida += cura;
        Console.WriteLine($"{Nome} usou uma poção e recuperou {cura} pontos de vida.");
    }
}

class Mago : Personagem
{
    public Mago(string nome, short vida) : base(nome, vida)
    {
        golpes.Add("Bola de fogo");
        golpes.Add("Raio de gelo");
        golpes.Add("Golpe de magia");
        golpes.Add("Golpe de magia negra");
        golpes.Add("Golpe de magia branca");
    }

    public override void curar()
    {
        short cura = (short)Random.Shared.Next(150, 251);
        Vida += cura;
        Console.WriteLine($"{Nome} usou uma magia de cura e recuperou {cura} pontos de vida.");
    }
}