// See https://aka.ms/new-console-template for more information
using EjemploDeBanco;
using EjemploDeBanco.Cuentas;

Console.WriteLine("Hello, World!");

//CuentaBancaria cuentaBancaria1 = new CuentaBancaria();
/*cuentaBancaria1.NumeroCuenta = 5656;
cuentaBancaria1.Saldo = 10000;
Console.WriteLine("Saldo inicial: " + cuentaBancaria1.Saldo);
cuentaBancaria1.Extraer(5000);
Console.WriteLine(cuentaBancaria1.Saldo);*/

Banco banco = new Banco();


CuentaCorriente cuentaCorriente1 = new CuentaCorriente(5005, 50000, 10000);
Console.WriteLine(cuentaCorriente1.Saldo);

banco.ExtraeDineroDeCuentaBancaria(cuentaCorriente1, 6000);
Console.WriteLine(cuentaCorriente1.Saldo);

CajaDeAhorro cajaDeAhorro1 = new CajaDeAhorro(5004, 10000);
Console.WriteLine(cajaDeAhorro1.Saldo);

banco.ExtraeDineroDeCuentaBancaria(cajaDeAhorro1, 1000);
Console.WriteLine(cajaDeAhorro1.Saldo);

Cliente cliente1 = new Cliente(5001); // constructor 1
Console.WriteLine(cliente1);

Cliente cliente2 = new Cliente(5002, "María", "López"); // constructor 2
Console.WriteLine(cliente2);

Cliente cliente3 = new Cliente(5003, "Fabián"); // constructor 3
Console.WriteLine(cliente3);
Console.ReadKey();

