using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    class Program
    {
        static void Main(string[] args)
        {

            var _animal = new Paloma();
            _animal.Comer();
            _animal.Dormir();
            _animal.Volar();
            //_animal.Correr();
            //_animal.Nadar();
            _animal.Defecar();
            _animal.Aparearse();
            
            Console.ReadKey();
        }
    }

}
