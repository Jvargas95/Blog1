using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog1
{
    class deportes : Blog
    {
        public deportes (string titulo, string contenido, string result) : base (titulo,contenido, result)
        {

        }

        public string Tennis { get; set; }
        public string Futbol { get; set; }
        public string Baloncesto { get; set; }
    }
}
