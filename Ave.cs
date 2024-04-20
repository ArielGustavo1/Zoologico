using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Ave : Animal
    {
        public Ave(string nombre, string especie) : base(nombre, especie)
        {
        }

        public override void accion()
        {
            Console.WriteLine("Volando");

        }
        public override void alimentarse()
        {
            Console.WriteLine("Comiendo insectos");

        }

    }
}
