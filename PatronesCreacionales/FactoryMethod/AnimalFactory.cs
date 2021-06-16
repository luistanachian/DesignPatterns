using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class AnimalFactory
    {
        public static Animal CrearAnimal(EspecieEnum especie)
        {
            switch (especie)
            {
                case EspecieEnum.Pato:
                    return new Pato();
                case EspecieEnum.Leon:
                    return new Leon();
                default:
                    return null;
            }
        }

    }
}
