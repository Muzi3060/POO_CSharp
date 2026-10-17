namespace Ex015;

public class Diario
{
    private List<string> segredos = new List<string>();
    private string Senha { get; set; }
    
    public Diario(string senha)
    {
        Senha = senha;
    }
    
    public void escrever(string mensagem)
    {
        segredos.Add(mensagem);
    }

    public void ler(string senha)
    {
        Console.WriteLine("Inicio do diário");
        
        if (senha == Senha) {
            foreach (string segredo in segredos) {
                Console.WriteLine(segredo);
            }
        }else {
            Console.WriteLine("Senha incorreta! Acesso negado.");
        }
        
        Console.WriteLine("Fim do diário");
    }
}