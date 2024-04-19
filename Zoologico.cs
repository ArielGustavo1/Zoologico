using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Zoologico
    {
        private List<Animal> animales;
        private List<Cuidador> cuidadores;

        public Zoologico() 
        { 
            animales = new List<Animal>();
            cuidadores = new List<Cuidador>();

        
        }
        public void agregarAnimal(Animal a)
        {
            animales.Add(a);
        }
        public void agregarCuidador(Cuidador c)
        {
            cuidadores.Add(c);
        }
        public void mostrarListas()
        {
            
            Console.WriteLine("------------Cuidadores------------");
            Console.WriteLine();

            foreach (Cuidador c in cuidadores)
            {
                Console.WriteLine("Cuidador: " +c.getNombre()+".");

            }
            Console.WriteLine();
            Console.WriteLine("------------Animales--------------");
            Console.WriteLine();

            foreach (Animal a in animales)
            {

                Console.WriteLine("Animal: " + a.getNombre() + ", Especie: " + a.getEspecie()+".");
            }

            Console.WriteLine();
            Console.WriteLine("--------Cuidador / Animal--------");
            Console.WriteLine();

            foreach (Cuidador c in cuidadores)
            {
                Console.WriteLine("Cuidador: " + c.getNombre() + ", Cuida a: ");
                c.mostrarListas();
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.WriteLine();

        }



    }
}
