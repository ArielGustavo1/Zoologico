using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Animal Eugenio = new Animal("Eugenio", "Rinoceronte");
            Animal Hermione = new Animal("Hermione", "Cocodrilo");
            Animal Margarita = new Animal("Margarita", "Leona");
            Animal Penelope = new Animal("Penélope", "Jirafa");
            Animal Gorifacio = new Animal("Gorifacio", "Gorila");
            Animal Jacinto = new Animal("Jacinto", "Oso Hormiguero");
            Animal Geremias = new Animal("Geremías", "Tigre");
            Animal Hilaria = new Animal("Hilaria", "Hipopótamo");

            Rigoberto.agregarAnimal(Eugenio);
            Rigoberto.agregarAnimal(Hermione);
            Ruperto.agregarAnimal(Margarita);
            Ruperto.agregarAnimal(Penelope);
            Arquimedes.agregarAnimal(Gorifacio);
            Arquimedes.agregarAnimal(Jacinto);
            Eustaquio.agregarAnimal(Geremias);
            Eustaquio.agregarAnimal(Hilaria);

            zoologico.agregarCuidador(Rigoberto);
            zoologico.agregarCuidador(Ruperto);
            zoologico.agregarCuidador(Arquimedes);
            zoologico.agregarCuidador(Eustaquio);

            zoologico.agregarAnimal(Eugenio);
            zoologico.agregarAnimal(Hermione);
            zoologico.agregarAnimal(Margarita);
            zoologico.agregarAnimal(Penelope);
            zoologico.agregarAnimal(Gorifacio);
            zoologico.agregarAnimal(Jacinto);
            zoologico.agregarAnimal(Geremias);
            zoologico.agregarAnimal(Hilaria);

            

            zoologico.mostrarListas();





        }
    }
}
