using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Pato : Animal
    {
        public Pato() => Console.WriteLine("Soy un Pato");
        public override void Andar() => Console.WriteLine("Camino y vuelo");
        public override void Comer() => Console.WriteLine("Me alimento de semillas");
    }
}
