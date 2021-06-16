using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Calendario.Instancia.PrintFecha();

            Calendario.Instancia.AddEvento("Cumpleaños de Luis", DateTime.Today.AddDays(33));
            Calendario.Instancia.PrintEventos();


            Calendario.Instancia.AddEvento("Salir a caminar", DateTime.Today.AddDays(7));
            Calendario.Instancia.AddEvento("Clase de ingles", DateTime.Today.AddDays(5));
            Calendario.Instancia.PrintEventos();


            Console.WriteLine("Push any key for exit...");
            Console.ReadKey();
        }
    }
}
