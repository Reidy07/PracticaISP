using Practica_ISP.Interfaces;
using System;

namespace Practica_ISP.Clases
{
    class Pato : IAveVoladora, IAveNadadora, IAveCantora, IAvePonedora
    {
        public void Volar()
        {
            Console.WriteLine("El pato está volando.");
        }

        public void Nadar()
        {
            Console.WriteLine("El pato está nadando.");
        }

        public void Cantar()
        {
            Console.WriteLine("El pato está cantando.");
        }

        public void PonerHuevos()
        {
            Console.WriteLine("El pato está poniendo huevos.");
        }
    }
