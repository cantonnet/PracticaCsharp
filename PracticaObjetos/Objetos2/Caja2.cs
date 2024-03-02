using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos2
{
    class Caja2
    {
        //Miembros variables
        private int largo;
        //private int ancho; ---> con el abordaje corto no es necesario declarar antes la variable
        private int alto;
        private int volumen;

        //Miembro metodo
        public void MuestraInfo()
        {
            Console.WriteLine("Largo = {0}, altura = {1}, ancho = {2}, volumen = {3}", largo, alto, Ancho, volumen = Ancho * alto * largo);
        }

        public int Largo { get { return largo; } set { largo = value; } }
        public int Ancho { get; set; }

        
    }
}
