using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog1
{
    class clima : Blog
    {
        public clima (string titulo, string contenido, string intereses) : base (titulo,contenido,intereses)
        {

        }
        
        public int Lluvioso { get; set;}
        public int Caluroso { get; set;}
        public int Nevado { get; set; }
    }
}
