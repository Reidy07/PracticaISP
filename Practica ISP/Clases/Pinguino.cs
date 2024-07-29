using Practica_ISP.Interfaces;
using System;

namespace Practica_ISP.Clases
{
    class Pinguino : IAveNadadora, IAvePonedora
    {
        public void Nadar()
        {
            Console.WriteLine("El pingüino está nadando.");
        }

        public void PonerHuevos()
        {
            Console.WriteLine("El pingüino está poniendo sus huevos.");
        }
    }
}
