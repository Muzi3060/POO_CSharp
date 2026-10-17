using Ex012;

Guerreiro kratos = new Guerreiro("Kratos", 1000);
Mago merlim = new Mago("Merlim", 1000);

kratos.Atacar(merlim, 500);

merlim.curar();

Console.WriteLine($"Kratos: {kratos.Vida}");
Console.WriteLine($"Merlim: {merlim.Vida}");