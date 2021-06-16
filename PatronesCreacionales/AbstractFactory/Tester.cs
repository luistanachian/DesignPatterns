using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Tester : Empleado
    {
        public Tester()
        {
            Console.WriteLine("Soy un Tester");
        }
        public override void Horario()
        {
            Console.WriteLine("Trabajo de 8 a 17");
        }

        public override void Salario()
        {
            Console.WriteLine("Gano 3000 dolares");
        }
    }
}
