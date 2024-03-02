using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto("HP que es", "Rojo");
            auto.MostrarDetalles();
            auto.Reparar();
            BMW bMW = new BMW("E40", "hpp", "Negro");
            bMW.MostrarDetalles();
            bMW.Reparar();

            var listautos = new List<Auto>
            {
                new Auto(),
                new BMW("H", "200", "azul"),
                new Audi()
            };
            foreach(var Auto  in listautos) { Auto.Reparar(); }
            Console.Read();
        }
    }
}
