using Ex016;

// Construtor padrão (base = 0, altura = 0)
Retangulo retangulo = new Retangulo();

// Definindo as medidas
retangulo.SetMedidas(8, 4);

// Obtendo a área
Console.WriteLine($"Área: {retangulo.GetArea()}"); // 32

// Obtendo e desconstruindo a tupla retornada por GetMedidas
var (baseAtual, alturaAtual) = retangulo.GetMedidas();
Console.WriteLine($"Base: {baseAtual}, Altura: {alturaAtual}");

// Também é possível acessar pelos nomes definidos na tupla:
// Ao invés de Item1 e Item2
var medidas = retangulo.GetMedidas();
Console.WriteLine($"Base: {medidas.Base}, Altura: {medidas.Altura}");