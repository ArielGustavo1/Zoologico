using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Cuidador
    {
        //
        private string nombre; 
        private List<Animal> animales;
        private List<Planta> plantas;
        public Cuidador(string nombre)
        {
            this.nombre = nombre;
            animales = new List<Animal>();
            plantas = new List<Planta>();
        }
        public void alimentar()
        {
           
            Console.WriteLine();
            Console.WriteLine(nombre+" alimentando: ");
            Console.WriteLine();

            foreach (Animal a in animales)
            {
                a.getNombre();
                a.getEspecie();
                a.alimentarse();
                Console.WriteLine();
            }
            foreach (Planta p in plantas)
            {
               
                p.getEspecie();
                p.alimentarse();
                Console.WriteLine();

            }
            Console.WriteLine();
        }
        public void agregarAnimal(Animal a)
        {
            animales.Add(a);
        }
        public void agregarPlanta(Planta p)
        {
            plantas.Add(p);
        }
        public void mostrarListas()
        {
            foreach (Animal a in animales)
            {
                Console.WriteLine("         Animal: " + a.getNombre() + ", "+a.getEspecie()+".");
            }
            foreach (Planta p in plantas)
            {
                Console.WriteLine("         Planta: " + p.getNombre() + ", " + p.getEspecie() + ".");
            }

        }
        public string getNombre()
        {
            return nombre;
        }
    }
}
