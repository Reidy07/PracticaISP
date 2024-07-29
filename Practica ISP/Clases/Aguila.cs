using Practica_ISP.Interfaces;
using System;


namespace Practica_ISP.Clases
{
    class Aguila : IAveVoladora, IAveCazadora
    {
        public void Volar()
        {
            Console.WriteLine("El águila está volando.");
        }

        public void Cazar()
        {
            Console.WriteLine("El águila está cazando.");
        }

    }
}    

