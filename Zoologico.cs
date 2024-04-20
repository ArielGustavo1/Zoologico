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
        private List<Planta> plantas;
        public Zoologico() 
        { 
            animales = new List<Animal>();
            cuidadores = new List<Cuidador>();
            plantas = new List<Planta>();
        
        }
        public void agregarAnimal(Animal a)
        {
            animales.Add(a);
        }
        public void agregarCuidador(Cuidador c)
        {
            cuidadores.Add(c);
        }
        public void agregarPlanta(Planta p)
        {
            plantas.Add(p);
        }

        public void alimentar()
        {
            foreach (Cuidador c in cuidadores)
            {
                c.alimentar();

            }
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
            Console.WriteLine("------------Plantas--------------");
            Console.WriteLine();
            

            foreach (Planta p in plantas)
            {

                Console.WriteLine("Plantas: " + p.getNombre() + ", Especie: " + p.getEspecie() + ".");
            }
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine("--------Cuidador / Animal / Planta--------");
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
