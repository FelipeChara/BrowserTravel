using Data.Model;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IBooksDL
    {
        /// <summary>
        /// Lista todos los libros disponibles
        /// </summary>
        /// <returns></returns>
        List<BookInfo> List();


        /// <summary>
        /// Obtener detalles del libreo
        /// </summary>
        /// <returns></returns>
        BookInfo GetById(int id);

    }
}
