using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Perro : Animal
    {

        public Perro()
        {

        }
        public Perro(string nombre) : base(nombre)
        {

        }

        public void ladrar()
        {
            Console.WriteLine("Guau guau");
        }

        public override void pensar()
        {
            Console.WriteLine("Guau??");
        }
    }
}
