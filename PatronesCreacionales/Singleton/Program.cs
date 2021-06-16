using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Calendario cal = Calendario.GetInstancia();
            cal.AddEvento("Cumpleaños de Luis", DateTime.Today.AddDays(33));
            cal.PrintEventos();

            Calendario cal2 = Calendario.GetInstancia();
            cal2.AddEvento("Salir a caminar", DateTime.Today.AddDays(7));
            cal2.AddEvento("Clase de ingles", DateTime.Today.AddDays(5));
            cal2.PrintEventos();

            Console.WriteLine("Push any key for exit...");
            Console.ReadKey();
        }
    }
}
