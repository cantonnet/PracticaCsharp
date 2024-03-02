using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos2
{
    class Humano
    {
        string primerNombre;
        string primerApellido;
        int edad;

        //Constructor parametrizado
        public Humano(string primerNombre, string primerApellido, int edad)
        {
            this.primerNombre = primerNombre;
            this.primerApellido = primerApellido;
            this.edad = edad;
        }

        //Constructor por defaul
        public Humano() { Console.WriteLine("Constructor por defaul llamado"); }


        public void presentarme()
        {
            Console.WriteLine("Hola soy {0} {1} y mi edad es {2} ", primerNombre, primerApellido, edad);
        }
    }
}
