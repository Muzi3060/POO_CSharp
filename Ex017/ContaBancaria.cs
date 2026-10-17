using System.Security.Cryptography;
using System.Text;

namespace Ex017;

public class ContaBancaria
{
    protected short Id { get; set; }
    protected string Titular { get; set; }
    private float Saldo { get; set; }
    private string Hash { get; set; }
    
    public ContaBancaria(short id, string titular, float saldo, string senha)
    {
        Id = id;
        Titular = titular;
        Saldo = saldo;
        Hash = GerarHash(senha);
    }

    private bool ValidarSenha(string chave)
    {
        return Hash != GerarHash(chave) ? throw new Exception("Senha inválida.") : true;
    }

    public float Sacar(float valor, string chave)
    {
        if (ValidarSenha(chave))
            return valor > Saldo || valor <= 0 ? throw new Exception("Saque inválido.") : Saldo -= valor;

        throw new Exception("Senha inválida.");
    }

    public float Depositar(float valor)
    {
        return valor <= 0 ? throw new Exception("Depósito inválido.") : Saldo += valor;
    }

    private string GerarHash(string senhaHash)
    {
        byte[] bytesEntrada = Encoding.UTF8.GetBytes(senhaHash);
        
        byte[] hashBytes = SHA256.HashData(bytesEntrada);

        return Convert.ToHexString(hashBytes).ToLowerInvariant();
    }
    
    public string ExibirSaldo(string chave)
    {
        return ValidarSenha(chave) ? $"Saldo atual: {Saldo}" : "Senha inválida.";
    }
}