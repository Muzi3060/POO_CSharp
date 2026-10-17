using Ex010;

List<Transporte> transportes = new List<Transporte>()
{
    new Moto(10),
    new Caminhao(50),
    new Drone(10)
};


foreach (var transporte in transportes)
{
    transporte.CalcularFrete();
    Console.WriteLine($"Transporte: {transporte.GetType().Name}, Distância: {transporte.Distancia} km, Frete: {transporte.Frete} R$");
}