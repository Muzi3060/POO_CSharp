namespace Ex022;

// PRIMARY CONSTRUCTOR (Construtor Primário - C# 12):
// Recebemos os parâmetros (nome, preco) direto no cabeçalho da classe.
// Isso evita ter que criar aquele método construtor tradicional gigante dentro da classe.
public class Produto(string nome, decimal preco)
{
    // Inicializamos as propriedades diretamente com os valores recebidos lá em cima.
    public string Nome { get; set; } = nome;
    public decimal Preco { get; set; } = preco;
}

public class Carrinho
{
    // <Produto> (Generics): É a "etiqueta da caixa". Garante segurança de tipo (Type Safety),
    // impedindo que alguém guarde textos ou números soltos aqui. Só entra Produto!
    // Possui apenas { get; } para impedir que alguém de fora substitua a lista inteira (ex: carrinho.Produtos = null).
    public List<Produto> Produtos { get; }

    // EXPRESSION-BODIED PROPERTY (Propriedade calculada):
    // O símbolo '=>' funciona como um 'get' automático. Toda vez que 'Total' for lido, 
    // o C# conta os itens da lista na hora e monta o texto atualizado.
    public string Total => $"Total de produtos: {Produtos.Count}";

    // SOBRECARGA DE CONSTRUTOR 1 (Público - A "Porta da Frente"):
    // Usado quando o cliente pega um carrinho novo e vazio no Program.cs: new Carrinho()
    // [] (Collection Expression): Forma moderna do C# 12 para criar uma lista vazia.
    // É exatamente o mesmo que escrever: Produtos = new List<Produto>();
    public Carrinho() => Produtos = [];

    // SOBRECARGA DE CONSTRUTOR 2 (Privado - "Uso Interno"):
    // É 'private' (Encapsulamento) para ninguém de fora criar um carrinho já cheio. 
    // Só quem pode chamar esse construtor é o nosso próprio operador '+' lá embaixo.
    //
    // IEnumerable<Produto>: É um "contrato" universal para qualquer coleção que possa ser percorrida (List, Array, etc).
    //
    // [.. produtos] (Spread Operator): Os colchetes [] criam uma lista nova na memória, e os dois pontos (..) 
    // "despejam" os itens da coleção antiga dentro da nova, um por um.
    // Isso evita que dois carrinhos apontem para a mesma lista na memória.
    // 
    // COMO SERIA SEM O [.. produtos] (Do jeito tradicional):
    // Produtos = new List<Produto>();
    // foreach (var item in produtos) 
    // {
    //     Produtos.Add(item);
    // }
    private Carrinho(IEnumerable<Produto> produtos) => Produtos = [.. produtos];
    
    // SOBRECARGA DO OPERADOR '+' (Somando dois Carrinhos):
    // Regras do C#: Precisa ser obrigatoriamente 'public' e 'static'.
    // O '?' (Nullable) avisa o compilador que c1 ou c2 podem chegar vazios (null) e que vamos tratar isso.
    public static Carrinho operator +(Carrinho? c1, Carrinho? c2)
    {
        // PROTEÇÃO CONTRA NULOS (Evita o erro NullReferenceException):
        // O operador '??' (Coalescência Nula) testa se o valor da esquerda é nulo.
        // Tradução da linha abaixo: Se c1 for nulo, retorne o c2. Mas se o c2 TAMBÉM for nulo (??), 
        // crie e retorne um carrinho novo vazio.
        //
        // COMO SERIA COM TERNÁRIO OU IF:
        // if (c1 is null) return (c2 != null) ? c2 : new Carrinho();
        if (c1 is null) return c2 ?? new Carrinho();
        
        // Se chegou aqui, c1 existe. Então se c2 for nulo, basta devolver o próprio c1.
        if (c2 is null) return c1;
        
        // ATUALIZAÇÃO MODERNA COM SPREAD OPERATOR [..]:
        // Em vez de criar uma variável 'novaLista' com new List() e depois chamar 'AddRange()',
        // abrimos uma nova lista [] e despejamos (..) os produtos de c1 e logo em seguida (..) os de c2!
        //
        // COMO ERA ANTES (Mais verboso):
        // var novaLista = new List<Produto>(c1.Produtos);
        // novaLista.AddRange(c2.Produtos); // AddRange adicionava a lista 2 inteira de uma vez
        // return new Carrinho(novaLista);
        List<Produto> novaLista = [.. c1.Produtos, .. c2.Produtos];
        
        // Chamamos o nosso construtor privado, entregando a lista unificada para nascer um 3º carrinho.
        return new Carrinho(novaLista);

        // DICA EXTRA: Você poderia até fazer tudo em uma linha só, sem a variável 'novaLista':
        // return new Carrinho([.. c1.Produtos, .. c2.Produtos]);
    }

    // SOBRECARGA DO OPERADOR '+' (Somando um Carrinho com um Produto avulso):
    public static Carrinho operator +(Carrinho? carrinho, Produto? produto)
    {
        // OPERADOR '??=' (Atribuição de Coalescência Nula):
        // Se a variável 'carrinho' for null, ele cria um new Carrinho() e guarda nela mesma.
        // Se já existir um carrinho ali, ele não faz nada.
        //
        // COMO SERIA COM IF TRADICIONAL:
        // if (carrinho is null) 
        // {
        //     carrinho = new Carrinho();
        // }
        carrinho ??= new Carrinho();

        // Só adiciona na lista se o produto realmente existir (não for nulo)
        if (produto is not null)
        {
            carrinho.Produtos.Add(produto);
        }
        
        return carrinho;
    }
}