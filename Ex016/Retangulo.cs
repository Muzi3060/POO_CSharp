namespace Ex016;

public class Retangulo
{
    public float Base { get; set; }
    public float Altura { get; set; }

    // Propriedade calculada: sempre retorna o valor atualizado de Base * Altura
    public float Area => Base * Altura;

    // Construtor com valores padrão (equivalente ao float base = 0 do C++)
    public Retangulo(float baseRetangulo = 0, float alturaRetangulo = 0)
    {
        Base = baseRetangulo;
        Altura = alturaRetangulo;
    }

    public float GetArea() => Area;

    public void SetBase(float b) => Base = b;
    public void SetAltura(float h) => Altura = h;

    // Desempacotamento de tupla em C# (equivalente ao auto [b, h] do C++)
    public void SetMedidas(float baseValor, float alturaValor)
    {
        (float b, float h) = (baseValor, alturaValor);
        Base = b;
        Altura = h;
    }

    // Retornando tupla com nomes nos campos
    public (float Base, float Altura) GetMedidas() => (Base, Altura);
}