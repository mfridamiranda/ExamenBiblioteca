﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Libro
    {
       public int IdLibro { get; set; }

        public string NombreLibro { get; set; }

        public int IdAutor { get; set; }
        public string NumeroPaginas { get; set; }
        public string FechaPublicacion { get; set; }
        public int IdEditorial { get; set; }
        public string Edicion { get; set; }
        public int IdGenero { get; set; }

    }
}
