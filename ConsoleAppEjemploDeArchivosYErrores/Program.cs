using ConsoleAppEjemploDeArchivosYErrores;
using log4net;

ILog log = LogManager.GetLogger("Principal.cs");//

log.Info("Inicio del programa");


try
{
    log.Debug("Estoy probando el try");
    EjemploErrorPropagado ejemploErrorPropagado = new EjemploErrorPropagado();
    ejemploErrorPropagado.HacerAlgoConError();

}
catch (NullReferenceException e)
{
    log.Error("Hay un error de null", e);
}
catch (Exception e)
{
    log.Error("Hay un error general", e);
}




ManejadorDeArchivos manejadorDeArchivo = new ManejadorDeArchivos();
try
{
    manejadorDeArchivo.LeerDatosCSV(@"C:\Users\claud\tmp\empleadosxxx.csv");
}
catch (Exception e)
{
    Console.WriteLine("Hay un error: " + e.Message);
}

log.Info("Fin del programa");



/*
StreamReader sr = null;

try
{
    sr = new StreamReader(@"E:\MuniCbaFullStack.NET-2023\Clases\Clase4-IO&Exceptions\tablalll.csv");
    string linea = sr.ReadLine();
    linea = sr.ReadLine(); //Ojo que la primera linea la tengo que ignorar porque son los títulos de la tabla

    while (linea != null)
    {
        //Console.WriteLine(linea);
        string[] datos = linea.Split(';');
        long id = long.Parse(datos[0]);
        string nombre = datos[1];
        string apellido = datos[2];
        double sueldo = double.Parse(datos[3]);
        Console.WriteLine(nombre + " " + apellido + " " + sueldo);
        linea = sr.ReadLine();
    }
} catch (Exception e)
{
    Console.WriteLine("Error al leer el archivo: " + e.Message); 
} 
finally
{
    try { sr.Close(); } catch { }
}
Console.WriteLine("Fin del programa");
*/



