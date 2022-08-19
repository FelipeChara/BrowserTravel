using Data.Models;
using System.Collections.Generic;

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
