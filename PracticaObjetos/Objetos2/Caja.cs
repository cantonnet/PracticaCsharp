using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos2
{
    class Caja
    {
        //Miembros variables
        private int largo;
        public int ancho;
        public int alto;
        public int volumen;

        //Miembro metodo
        public void MuestraInfo()
        {
            Console.WriteLine("Largo = {0}, altura = {1}, ancho = {2}, volumen = {3}", largo, alto, ancho, volumen = ancho * alto * largo);
        }

        public void SetLargo(int largo) 
        {
            this.largo = largo;
        }

        public int GetLargo() 
        {
            return this.largo;
        }
    }
}
