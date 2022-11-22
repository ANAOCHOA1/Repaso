using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    internal class Humano : Animal
    {
        public Humano(string nombre) : base(nombre) { }

        public override void pensar()
        {
            Console.WriteLine("Soy un humano, estoy pensando");
        }
    }
}
