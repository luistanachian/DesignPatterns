using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class SandwichDeQuesoTostadoBuilder : SandwichBuilder
    {
        public override Pan PanBuilder() => new PanTostado();
        public override Relleno RellenoBuilder() => new Queso();
    }
}
