using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class Relleno
    {
        protected string ingrediente;
        public string Ingrediente { get { return ingrediente; } }
    }

    public class Queso : Relleno
    {
        public Queso()
        {
            ingrediente = "Queso";
        }
    }

    public class Atun : Relleno
    {
        public Atun()
        {
            ingrediente = "Atun";
        }
    }
}
