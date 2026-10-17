using Ex022;

// Chama o Construtor 1 (Público e vazio)
var carrinho1 = new Carrinho();
carrinho1.Produtos.Add(new Produto("Teclado", 250m));

var carrinho2 = new Carrinho();
carrinho2.Produtos.Add(new Produto("Mouse", 120m));

// O GRANDE TRUQUE DO '+=':
// No C#, o '+=' vem de graça quando criamos o operador '+'.
// Por trás dos panos, o compilador traduz essa linha exatamente para:
// carrinho1 = carrinho1 + carrinho2;
//
// O que acontece na memória:
// 1. O método operator +(Carrinho, Carrinho) junta os itens e fabrica um 3º Carrinho novo.
// 2. O sinal de '=' arranca a etiqueta "carrinho1" do carrinho antigo e cola nesse 3º Carrinho novo.
// 3. O carrinho antigo (que só tinha o teclado) fica sem referência e é limpo da memória pelo Garbage Collector.
carrinho1 += carrinho2;

Console.WriteLine(carrinho1.Total); // Saída: Total de produtos: 2

// Aqui o compilador percebe que na direita temos um 'Produto' e não um 'Carrinho'.
// Então ele chama automaticamente a segunda sobrecarga: operator +(Carrinho, Produto)
// Tradução nos bastidores: carrinho1 = carrinho1 + new Produto("Monitor", 1000m);
carrinho1 += new Produto("Monitor", 1000m);

Console.WriteLine(carrinho1.Total); // Saída: Total de produtos: 3