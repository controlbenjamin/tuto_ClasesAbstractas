using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public class Paloma : Aves
    {
        
        public override void Comer()
        {
            Console.WriteLine("Comiendo como una Paloma");
        }

        public override void Dormir()
        {
            Console.WriteLine("Durmiendo como una Paloma");
        }

        public override void Volar()
        {
            Console.WriteLine("Volando como una Paloma");
        }


        public override void Defecar()
        {
            base.Defecar();
            Console.WriteLine("Mas todavia!");
        }

    }
}
