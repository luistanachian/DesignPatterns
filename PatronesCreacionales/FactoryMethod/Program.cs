using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = AnimalFactory.CrearAnimal(EspecieEnum.Leon);
            animal.Andar();
            animal.Comer();

            Console.WriteLine();

            animal = AnimalFactory.CrearAnimal(EspecieEnum.Pato);
            animal.Andar();
            animal.Comer();

            Console.WriteLine("------------------------");
            Console.WriteLine("Push any key for exit...");
            Console.ReadKey();
        }
    }
}
