using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class BMW:Auto
    {
        private string marca = "BMW";

        public BMW() { }

        public BMW(string modelo, string hp, string color)
        {
            this.Modelo = modelo;
            this.HP = hp;
            this.Color = color;
        }

        public string Modelo { get; set; }

        public new void MostrarDetalles()
        {
            Console.WriteLine("Color = {0} \nHP = {1}\nMarca = {2}\nModelo = {3}", Color, HP, marca, Modelo);
        }

        public override void Reparar()
        { Console.WriteLine("{0} Reparado", marca); }
    }
}
