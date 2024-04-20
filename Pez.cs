using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Pez : Animal
    {
        public Pez(string nombre, string especie) : base(nombre, especie)
        {
        }

        public override void accion()
        {
            Console.WriteLine("Nadando");
        }
        public override void alimentarse()
        {
            Console.WriteLine("Comiendo comida para peces");
        }
    }
}
