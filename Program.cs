using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "1234", modelo: "modelo x", imei: "123456789", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Angry birds");

Console.WriteLine("\nSmartphone Iphone:");
Smartphone iphone = new Iphone(numero: "4321", modelo: "modelo y", imei: "987654321", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Uber");