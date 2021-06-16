using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Leon : Animal
    {
        public Leon() => Console.WriteLine("Soy un Leon");
        public override void Andar() => Console.WriteLine("Corro rapido");
        public override void Comer() => Console.WriteLine("Me alimento otros animales");
    }
}
