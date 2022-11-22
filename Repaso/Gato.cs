using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Gato : Animal
    {
        private string raza;
        private int edad;

        //METODO CONSTRUCTOR
        public Gato()
        {

        }

        public Gato(string nombre) : base (nombre){
        
        }

        public Gato(string parametroRaza, int parametroEdad)
        {
            this.raza = parametroRaza;
            this.edad = parametroEdad;
        }



        public void maullar()
        {
            Console.WriteLine("Miau!..");
        }

        public void informacionGato()
        {
            Console.WriteLine(
                "El gato pertenece a la raza: " + this.raza + "\n" +
                "además tiene " + this.edad + " años gatunos"
                );
        }

        public override void pensar()
        {
            Console.WriteLine("Estoy pensando, miau");
        }

        // Getters y setters
        public void setRaza(string parametroRaza){
            this.raza = parametroRaza;
        }

        public string getRaza()
        {
            return this.raza;
        }

        public void setEdad(int parametroEdad)
        {
            this.edad = parametroEdad;
        }

        public int getEdad()
        {
            return this.edad;
        }


    }
}
