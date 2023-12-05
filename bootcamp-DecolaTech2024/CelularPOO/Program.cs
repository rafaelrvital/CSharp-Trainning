using DesafioPOO.Models;

Nokia nokia = new Nokia(numero:"+55 (28) 97996-3716", modelo: "Nokia G60", imei: "351814804015153", memoria: 128);
nokia.InstalarAplicativo("Instagram");
nokia.Ligar();

Console.WriteLine();

Iphone iphone = new Iphone(numero: "+55 (65) 98072-3751", modelo: "Iphone SE", imei: "359213073876951", memoria: 64);
iphone.InstalarAplicativo("Facebook");
iphone.ReceberLigacao();