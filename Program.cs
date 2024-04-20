using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Nuevo ZOOLOGICO

Enunciado del problema:

Un zoológico desea desarrollar un sistema para gestionar sus animales y cuidadores. 
El sistema debe permitir la creación y gestión de diferentes tipos de animales, incluyendo mamíferos, 
aves, peces y una planta carnívora. Cada animal debe tener un nombre, una especie y un tipo de comida asociado. 
Los mamíferos deben ser capaces de amamantar, las aves deben poder volar y los peces deben poder nadar. Además, se 
requiere la capacidad de crear una planta carnívora que se alimente de otros seres vivos.

Los cuidadores serán responsables de alimentar a los animales. Cada cuidador debe tener un nombre y ser capaz de alimentar 
a los animales bajo su cuidado con la comida adecuada. Esto incluye tanto a los animales convencionales como a la planta carnívora.

El zoológico debe tener la capacidad de administrar tanto a los animales como a los cuidadores. Esto implica la capacidad 
de agregar, eliminar y actualizar la información de los animales y cuidadores. Además, el zoológico debe ser capaz de mostrar
la lista de animales y cuidadores disponibles.
El sistema debe ser implementado en C# y ejecutarse por consola. Los alumnos deberán utilizar herencia, polimorfismo, 
interfaces y métodos virtuales para garantizar la flexibilidad y extensibilidad del sistema. Además, se debe implementar 
la inyección de dependencias para permitir que los cuidadores alimenten a cualquier tipo de animal, incluida la planta carnívora.
 */
namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoologico zoologico = new Zoologico();  

            Cuidador Rigoberto = new Cuidador("Rigoberto");
            Cuidador Ruperto = new Cuidador("Ruperto");
            Cuidador Arquimedes = new Cuidador("Arquímedes");
            Cuidador Eustaquio = new Cuidador("Eustaquio");

            Animal Zenaida = new Mamifero("Zenaida", "Rinoceronte");
            Animal Margarita = new Mamifero("Margarita", "Leona");
            Animal Penelope = new Mamifero("Penélope", "Jirafa");
            Animal Gorifacio = new Ave("Gorifacio", "Cisne");
            Animal Jacinto = new Pez("Jacinto", "Pez de Colores");
            Animal Geremias = new Ave("Geremías", "Pato");
            Animal Hilaria = new Pez("Hilaria", "Atún");
            Planta planta1 = new Planta("Enredadera");
            Planta planta2 = new Planta("Carnívora");
            Planta planta3 = new Planta("Hiedra");


            Rigoberto.agregarAnimal(Zenaida);
            Rigoberto.agregarAnimal(Margarita);
            Ruperto.agregarAnimal(Penelope);
            Ruperto.agregarAnimal(Gorifacio);
            Arquimedes.agregarAnimal(Jacinto);
            Arquimedes.agregarAnimal(Geremias);
            Arquimedes.agregarAnimal(Hilaria);
            Eustaquio.agregarPlanta(planta1);
            Eustaquio.agregarPlanta(planta2);
            Eustaquio.agregarPlanta(planta3);

            zoologico.agregarCuidador(Rigoberto);
            zoologico.agregarCuidador(Ruperto);
            zoologico.agregarCuidador(Arquimedes);
            zoologico.agregarCuidador(Eustaquio);

            zoologico.agregarAnimal(Zenaida);
            zoologico.agregarAnimal(Margarita);
            zoologico.agregarAnimal(Penelope);
            zoologico.agregarAnimal(Gorifacio);
            zoologico.agregarAnimal(Jacinto);
            zoologico.agregarAnimal(Geremias);
            zoologico.agregarAnimal(Hilaria);
            zoologico.agregarPlanta(planta1);
            zoologico.agregarPlanta(planta2);
            zoologico.agregarPlanta(planta3);

            Console.WriteLine("================Lista del Zoo=================\n");
            zoologico.mostrarListas();
            Console.WriteLine("=================Alimentando=================");
            zoologico.alimentar();
            Console.WriteLine("===================Accion===================");
            zoologico.accion();

        }
    }
}
