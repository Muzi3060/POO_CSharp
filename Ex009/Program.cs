using Ex009;

List<BebidaQuente> pedidos = new()
{ 
    new Cafe(), 
    new Cha(), 
    new Leite() 
};

foreach (var bebida in pedidos)
{
    bebida.Preparar();
}

