using Ex005;

Gamer gamer1 = new Gamer("João", "Judge");

gamer1.mostrarFicha();
Console.WriteLine("================================");

gamer1.adicionarJogosFavoritos("The Witcher 3");
gamer1.adicionarJogosFavoritos("Cyberpunk 2077");
gamer1.adicionarJogosFavoritos("Persona 5 royal");
gamer1.adicionarJogosFavoritos("Visions of Mana");
gamer1.adicionarJogosFavoritos("Final fantasy 7 remake");

gamer1.mostrarFicha();
