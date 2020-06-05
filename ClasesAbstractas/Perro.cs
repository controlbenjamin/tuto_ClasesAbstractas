using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public class Perro : Mamiferos
    {
       
        public override void Comer()
        {
            Console.WriteLine("Comiendo como un Perro");
        }

        public override void Correr()
        {
            Console.WriteLine("Corriendo como un Perro");
        }

        public override void Dormir()
        {
            Console.WriteLine("Durmiendo como un Perro");
        }
    }
}
