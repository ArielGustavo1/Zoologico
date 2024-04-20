using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Planta
    {
        private string especie;

        public Planta(string especie)
        {
            this.especie = especie;
        }

        public string getEspecie()
        {
            return especie;
        }
        public string getNombre()
        {
            return "Sin nombre";
        }
        public void alimentarse()
        {
            
            Console.WriteLine("Alimentandose a través de nutrientes ");
        }
    }
}
