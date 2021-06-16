using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Programador : Empleado
    {
        public Programador()
        {
            Console.WriteLine("Soy un Programador");
        }
        public override void Horario()
        {
            Console.WriteLine("Trabajo de 9 a 20");
        }

        public override void Salario()
        {
            Console.WriteLine("Gano 5000 dolares");
        }
    }
}
