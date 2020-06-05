using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public class Tiburon : Peces
    {
        
        public override void Comer()
        {
            Console.WriteLine("Comiendo como un Tiburon");
        }

        public override void Dormir()
        {
            Console.WriteLine("Durmiendo como un Tiburon");
        }

        public override void Nadar()
        {
            Console.WriteLine("Nadando como un Tiburon");
        }
    }
}
