using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Construir(new SandwichDeAtunBuilder());
            Construir(new SandwichDeQuesoBuilder());
            Construir(new SandwichDeQuesoTostadoBuilder());

            Console.WriteLine("------------------------");
            Console.WriteLine("Push any key for exit...");
            Console.ReadKey();
        }

        public static void Construir(SandwichBuilder builder)
        {
            Sandwich sandwich = builder.BuildSandwich();
            sandwich.Descripcion();
        }
    }
}
