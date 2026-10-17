using Ex021;

var pagamentos = new List<Pagamento>()
{
    new Boleto(100),
    new Pix(200),
    new Credito(300)
};

foreach (var pagamento in pagamentos)
{
    pagamento.Pagar();
}