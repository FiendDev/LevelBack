﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Models;

namespace Negocio.Libro
{
    internal interface ILibro
    {

        List<Libros> GetLibros();
    }
}
