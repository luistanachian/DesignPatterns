using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class Pan
    {
        protected string tipo;
        public string Tipo { get { return tipo; } }
    }

    public class PanTostado : Pan
    {
        public PanTostado()
        {
            tipo = "Tostado";
        }
    }

    public class PanBlando : Pan
    {
        public PanBlando()
        {
            tipo = "Blando";
        }
    }
}
