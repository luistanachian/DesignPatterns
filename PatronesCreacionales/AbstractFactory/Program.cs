using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Tester();
            empleado.Horario();
            empleado.Salario();

            Console.WriteLine();

            empleado = new Programador();
            empleado.Horario();
            empleado.Salario();

            Console.WriteLine("------------------------");
            Console.WriteLine("Push any key for exit...");
            Console.ReadKey();
        }
    }
}
