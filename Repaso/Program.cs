// See https://aka.ms/new-console-template for more information

using Repaso;


/*
Perro bobby = new Perro("Bobby");
bobby.pensar();
bobby.ladrar();
bobby.getNombre();

Humano ana = new Humano("Ana");
ana.pensar();
ana.getNombre();
*/

/*
Gato objetoGato = new Gato();
objetoGato.maullar();
*/

Gato objetoGato2 = new Gato("Trueno");
objetoGato2.setEdad(13);
objetoGato2.setRaza("Panterita");
objetoGato2.informacionGato();

// Este metodo se hereda de la clase animal pero tiene que implementarse por que es un metodo abstracto
objetoGato2.pensar();

// Metodos que obtiene el objeto de la clase por herencia de la clase animal
objetoGato2.getNombre();
objetoGato2.respirar();
