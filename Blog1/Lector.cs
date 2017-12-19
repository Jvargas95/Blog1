using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog1
{
    class Lector : Blog
    {
        public Lector (string titulo, string contenido, string intereses) : base (titulo,contenido,intereses)
        {

        }

        public string lee_not { get; set; }
    }
}
