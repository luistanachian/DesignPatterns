using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class SandwichBuilder
    {
        public abstract Pan PanBuilder();
        public abstract Relleno RellenoBuilder();


        public Sandwich BuildSandwich()
        {
            Pan pan = PanBuilder();
            Relleno relleno = RellenoBuilder();

            return new Sandwich(pan, relleno);
        }



    }
}
