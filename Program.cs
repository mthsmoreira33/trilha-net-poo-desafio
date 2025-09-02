using DesafioPOO.Models;
Smartphone nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 64);
Smartphone iphone = new Iphone("987654321", "iPhone 13", "987654321098765", 128);

Console.WriteLine($"Nokia: {nokia.Modelo}, IMEI: {nokia.IMEI}, Memória: {nokia.Memoria}GB");
nokia.Ligar();
nokia.InstalarAplicativo("Snake");
nokia.ReceberLigacao();

Console.WriteLine($"\niPhone: {iphone.Modelo}, IMEI: {iphone.IMEI}, Memória: {iphone.Memoria}GB");
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();
