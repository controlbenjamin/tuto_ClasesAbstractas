using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public abstract class Animal
    {
        
        public abstract void Comer();

        public abstract void Dormir();

        public virtual void Aparearse()
        {

            Console.WriteLine("Apareandose como animales!!");
        }

    }
}
