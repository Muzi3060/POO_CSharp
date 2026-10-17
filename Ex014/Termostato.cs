namespace Ex014;

public class Termostato
{
    // Campo privado de suporte (backing field)
    private float _temperatura = 24.5f;

    // Propriedade completa
    public float Temperatura
    {
        get => _temperatura;
         
        set
        {
            // Lógica personalizada / validação antes de atribuir
            // A palavra-chave 'value' contém o valor passado na atribuição
            
            
            if (value <= 16 ) {
                _temperatura = 16;
            }else if (value >= 30) {
                _temperatura = 30;
            }else {
                if ((value * 2) % 1 != 0) {
                    Console.WriteLine("Temperatura inválida. A temperatura deve ser um número inteiro ou meio inteiro.");
                }
                else {
                    _temperatura = value;
                }
            }
        }
    }
    public string MostrarTemperatura() => $"A temperatura atual é: {Temperatura}°C";
}