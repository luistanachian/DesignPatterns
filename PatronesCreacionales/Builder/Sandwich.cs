using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Sandwich
    {
        private Pan pan;
        private Relleno relleno;

        public void Descripcion() =>
            Console.WriteLine($"El Sandwich es de pan {pan.Tipo} y relleno de {relleno.Ingrediente}");

        public Sandwich(Pan pan, Relleno relleno)
        {
            this.pan = pan;
            this.relleno = relleno;
        }
    }
}
