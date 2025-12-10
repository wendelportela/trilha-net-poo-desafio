using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Console.WriteLine("Smartphone Nokia");
Smartphone nokia1 = new Nokia(numero: "123456789", modelo: "Modelo 1", imei: "11111111111", memoria: 128);
nokia1.Ligar();
nokia1.InstalarAplicativo("Twitter");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone Iphone1 = new Iphone(numero: "123456789", modelo: "Modelo 1", imei: "11111111111", memoria: 128);
Iphone1.ReceberLigacao();
Iphone1.InstalarAplicativo("WhatsApp");
