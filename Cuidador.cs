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

        public Cuidador(string nombre)
        {
            this.nombre = nombre;
            animales = new List<Animal>();
        }
        public void alimentarAnimal()
        {
            Console.WriteLine("Alimentando al animal");
        }
        public void agregarAnimal(Animal a)
        {
            animales.Add(a);
        }
        public void mostrarListas()
        {
            foreach (Animal a in animales)
            {
                Console.WriteLine("         Animal: " + a.getNombre() + ", "+a.getEspecie()+".");
            }

        }
        public string getNombre()
        {
            return nombre;
        }
    }
}
