using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456789", "Modelo 1", "123456", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Pokemon");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Nokia("123456789", "Modelo 2", "123456", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("facebook");