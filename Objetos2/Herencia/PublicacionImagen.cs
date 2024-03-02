using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class PublicacionImagen:Publicacion
    {
        //Propiedad nueva
        public string UrlImagen { get; set; }

        //Constructor por defecto
        public PublicacionImagen() { }

        //Constructor parametrizado
        public PublicacionImagen(string titulo, string autor, string urlImagen, bool esPublico) 
        {
            this.UrlImagen = urlImagen;
            this.Id = CrearID();
            this.Autor = autor;
            this.Titulo = titulo;
            this.esPublico = esPublico;
        }

        public override string ToString()
        {
            return String.Format(" {0} - {1} - Creado por {2} - {3}", this.Id, this.Titulo, this.Autor, this.UrlImagen);
        }
    }
}
