﻿using Data.Interfaces;
using Data.Model;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Data.Access
{
    public class BooksDL : IBooksDL
    {
        private readonly TravelContext _context;

        public BooksDL(TravelContext context)
        {
            _context = context;
        }

        public BookInfo GetById(int id)
        {
            var query = from b in _context.Libros
                        where b.Isbn == id
                        select new BookInfo()
                        {
                            Id = b.Isbn,
                            Titulo = b.Titulo,
                            Sinopsis = b.Sinopsis,
                            Paginas = b.NPaginas,
                            NombreEditorial = b.Editoriales.Nombre,
                            SedeEditorial = b.Editoriales.Sede
                        };

            return query.FirstOrDefault();
        }

        public List<BookInfo> List()
        {
            var query = from b in _context.Libros
                        select new BookInfo()
                        {
                            Id = b.Isbn,
                            Titulo = b.Titulo,
                            Sinopsis = b.Sinopsis,
                            Paginas = b.NPaginas
                        };

            return query.ToList();
        }
    }
}