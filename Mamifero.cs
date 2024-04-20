using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Mamifero : Animal
    {
        private string comida;

        public Mamifero(string nombre, string especie) : base(nombre, especie)
        {
        }

        public void setComida(string s)
        {
            this.comida = s;
        }
        public override void accion()
        {
            Console.WriteLine("Amamantando");
        }
        public override void alimentarse()
        {
            Console.WriteLine(getNombre()+" Mamando ");
        }

    }
}
