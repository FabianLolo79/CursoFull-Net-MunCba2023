// See https://aka.ms/new-console-template for more information

using ConsoleAppEjemploADONET;

ManejadorDeArticulos manejadorDeArticulos = new ManejadorDeArticulos();
Articulo articulo = new Articulo();
articulo.Nombre = "Nuevo ejemplo";
articulo.Precio = 5656;

List<Articulo> articulos = manejadorDeArticulos.RecuperarArticulos();
foreach (Articulo item in articulos)
{
    Console.WriteLine(item.Nombre);
    Console.WriteLine(item.Precio);
    Console.WriteLine("/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*");
}





