using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public abstract class Aves : Animal
    {

        public abstract void Volar();

        public virtual void Defecar() {

            Console.WriteLine("Defecar desde el arbol como una paloma!!!!");
        }
    }
}
