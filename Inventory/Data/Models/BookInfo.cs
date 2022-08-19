using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class BookInfo
    {
        /// <summary>
        /// Id Libro
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Titulo Libro
        /// </summary>
        public string Titulo { get; set; }

        /// <summary>
        /// Sinopsis Libro
        /// </summary>
        public string Sinopsis { get; set; }

        /// <summary>
        /// Numero paginas Libro
        /// </summary>
        public string Paginas { get; set; }

        /// <summary>
        /// Informacion Autor
        /// </summary>
        public List<AutorBookInfo> Autor { get; set; }

        /// <summary>
        /// Nombre Editorial
        /// </summary>
        public string NombreEditorial { get; set; }

        /// <summary>
        /// Sede Editorial
        /// </summary>
        public string SedeEditorial { get; set; }
    }

    public class AutorBookInfo
    {
        /// <summary>
        /// Nombre Autor
        /// </summary>
        public string NombreAutor { get; set; }

        /// <summary>
        /// Apellido Autor
        /// </summary>
        public string ApellidoAutor { get; set; }
    }
}
