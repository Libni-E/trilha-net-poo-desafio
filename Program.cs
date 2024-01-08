using DesafioPOO.Models;
Console.WriteLine("Iphone");
Iphone iphone = new Iphone ("(11)95857-4576", "Iphone 15 plus", "1256255625", 126 );
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");

Console.WriteLine("\n\n\n");

Console.WriteLine("Nokia");
Nokia nokia = new Nokia ("(11)97458-9546", "Nokia 5s", "1555415455", 126 );
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");