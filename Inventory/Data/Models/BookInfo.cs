using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class BookInfo
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Sinopsis { get; set; }

        public string Paginas { get; set; }

        public string NombreAutor { get; set; }

        public string ApellidoAutor { get; set; }

        public string NombreEditorial { get; set; }

        public string SedeEditorial { get; set; }
    }
}
