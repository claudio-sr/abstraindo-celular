using projeto_abstraindo_celular.Models;

Console.WriteLine("Smartphone Nokia: ");

var nokia = new Nokia(numero: "123456", modelo: "1100", imei: "11223344", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
var iphone = new Iphone(numero: "123456", modelo: "1100", imei: "11223344", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
