using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog1
{
    class Autor : Blog
    {
        public Autor(string titulo, string contenido, string intereses) : base (string Titulo, string Contenido, string Intereses)
        {

        }

        public string Escribe_not { get; set; }
        public string Pub_not { get; set; }
    }
}
