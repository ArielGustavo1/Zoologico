using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Animal
    {
        private string nombre {  get; set; }
        private string especie {  get; set; }

        public Animal(string nombre, string especie)
        {
            this.nombre = nombre;
            this.especie = especie;
        }

        public void comiendo()
        {
            Console.WriteLine("Comiendo");
        }
        public string getNombre()
        {
            return nombre;
        }
        public string getEspecie()
        {
            return especie;
        }

        public virtual void alimentarse()
        {
            Console.WriteLine("Se alimenta en forma genérica");
        }
        public virtual void accion()
        {
            Console.WriteLine("Acción genérica del animal");
        }

    }
}
