using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class SandwichDeQuesoBuilder : SandwichBuilder
    {
        public override Pan PanBuilder() => new PanBlando();
        public override Relleno RellenoBuilder() => new Queso();
    }
}
