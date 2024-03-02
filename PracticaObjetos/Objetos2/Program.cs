using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Humano Martin = new Humano("Martin", "Cardozo", 40);
            Martin.presentarme();
            Humano Basico = new Humano();
            Basico.presentarme();
            Caja caja = new Caja();
            caja.SetLargo(5);
            caja.alto = 2;
            caja.ancho = 1;
            caja.MuestraInfo();

            Caja2 cajita2 = new Caja2();
            Console.WriteLine(cajita2.Largo);
            cajita2.Ancho = 2;
            Console.WriteLine(cajita2.Ancho);
            Console.Read();
        }
    }
}
