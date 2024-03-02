using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publicacion post1 = new Publicacion("Gracias saludos!", true, "Marcos Sosa");
            Console.WriteLine(post1.ToString());
            PublicacionImagen imagen = new PublicacionImagen("Mira esto", "Julio", "imagen", true);
            Console.WriteLine(imagen.ToString());
            Console.Read();
        }
    }
}
