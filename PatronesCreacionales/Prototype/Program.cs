using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Gato gato1 = new() { Edad = 10 };
            gato1.Rasgos = new Rasgos() { Tamaño = "Grande" };
            Gato gato2 = gato1.Clone() as Gato;
            gato2.Edad = 5;
            gato1.Rasgos.Tamaño = "Mediano";

            Console.WriteLine($"Edad gato1: {gato1.Edad}, " +
                $"Edad gato2: {gato2.Edad}");
            Console.WriteLine($"Tamaño gato1: {gato1.Rasgos.Tamaño}, " +
                $"Tamaño gato2: {gato2.Rasgos.Tamaño}");

            Console.WriteLine("------------------------");
            Console.WriteLine("Push any key for exit...");
            Console.ReadKey();
        }
    }
}
