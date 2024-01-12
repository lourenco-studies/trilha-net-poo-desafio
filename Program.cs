using DesafioPOO.Models;

Smartphone nokia = new Nokia("123456", "Tijolão", "134679", 32);
nokia.Ligar();
nokia.InstalarAplicativo("Candy Crush");

Console.WriteLine("");

Smartphone iphone = new Iphone("78901", "XS", "24680", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");