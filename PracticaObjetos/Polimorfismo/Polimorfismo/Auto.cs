using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Auto
    {
        public string HP { get; set; }
        public string Color { get; set; }

        //Constructor default
        public Auto() { }

        //Constructor parametrizado
        public Auto(string hp, string color) 
        {
            this.HP = hp;
            this.Color = color;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine("Color = {0} \nHP = {1}", Color, HP);
        }

        public virtual void Reparar()
        { Console.WriteLine("Auto Reparado"); }
    }
}
