using DesafioPOO.Models;

Console.WriteLine("Smartphone NOKIA: ");
Smartphone nokia = new Nokia("25452487", "Modelo1", "11111111", 87);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("---------------------------------------------");

Console.WriteLine("Smartphone IPHONE: ");
Smartphone iphone = new Iphone("17817", "Modelo2", "222222222222", 84);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");


Console.ReadKey();