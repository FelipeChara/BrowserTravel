﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Model
{
    public partial class AutoresHasLibro
    {
        public int AutoresId { get; set; }
        public int LibrosIsbn { get; set; }

        public virtual Autore Autores { get; set; }
        public virtual Libro LibrosIsbnNavigation { get; set; }
    }
}
