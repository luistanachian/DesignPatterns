using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    //ICloneable  se usa para generar la clase clone y permitir la clonacion
    public class Gato : ICloneable 
    {
        public int Edad { get; set; }
        public Rasgos Rasgos { get; set; }

        public object Clone()
        {
            //instanciar la misma clase con una clonacion simple
            //la clonacion simple solo clona propiedades que no sean clases
            Gato gato = this.MemberwiseClone() as Gato;

            //para clonar tambien propiedades tipo clases hay que instanciar
            //una nueva clase y asignarla a la propiedad correspondiente
            Rasgos rasgos = new() 
            { 
                Tamaño = this.Rasgos.Tamaño 
            };
            gato.Rasgos = rasgos;

            //despues retornar la clase
            return gato;
        }
    }

    public class Rasgos
    {
        public string Tamaño { get; set; }
    }
}
