using Ex020;

var arquivo = new Pdf("contrato", 1300.000f);
Console.WriteLine(arquivo.Abrir());
var arquivo2 = new Doc("prova", 250.000f);
Console.WriteLine(arquivo2.Abrir());

