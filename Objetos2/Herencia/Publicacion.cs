using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Publicacion
    {
        private static int publicacionID;
        // Propiedades
        protected int Id { get; set; }
        protected string Titulo { get; set; }
        protected string Autor {  get; set; }
        protected bool esPublico { get; set; }

        //constructor por defecto
        public Publicacion()
        { 
            Id = CrearID();
            Titulo = string.Empty;
            Autor = string.Empty;
            esPublico = true;
        }

        //constructor parametrizado
        public Publicacion(string titulo, bool esPublico, string autor)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.esPublico = esPublico;
            this.Id = CrearID();
            
        }

        //Metodo para crear ID
        protected int CrearID()
        {
            return ++publicacionID;
        }

        //Metodo para editar publicacion
        public void Editar(string titulo, bool esPublico)
        {
            this.Titulo = titulo;
            this.esPublico = esPublico;
        }

        public override string ToString()
        {
            return String.Format(" {0} - {1} - Creado por {2}", this.Id, this.Titulo, this.Autor);
        }
    }
}
