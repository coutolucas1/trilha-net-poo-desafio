using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Nokia nokia3310 = new Nokia("977779999", "3310", "1568478521", 16);
nokia3310.ReceberLigacao();
nokia3310.InstalarAplicativo("Caixa Tem");
nokia3310.Ligar("994563215");

Console.WriteLine("-----------------------------------------------------------------------------");
Console.WriteLine("Smartphone Iphone: ");
Iphone iphone15 = new Iphone("988885555", "Iphone 15 Pro Max Ex Plus Alpha", "5987456325", 64);
iphone15.ReceberLigacao();
iphone15.InstalarAplicativo("Toro Investimentos");

