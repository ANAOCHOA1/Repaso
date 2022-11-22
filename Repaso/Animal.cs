using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public abstract class Animal
    {
        protected string nombre;

        public Animal()
        {

        }

        public Animal(string nombre)
        {
            this.nombre = nombre;
        }


        public void respirar()
        {
            Console.WriteLine("Estoy respirando");
        }

        public abstract void pensar();


        public void getNombre()
        {
            Console.WriteLine("Mi nombre es: " + this.nombre);
        }

    }
}
