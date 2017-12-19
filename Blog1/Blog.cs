using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog1
{
    class Blog
    {
        public DateTime fechacreacion { get; set; }
        public string titulo { get; set; }
        public string contenido { get; set; }
        public string result { get; set; }

        public Blog(string Titulo, string Contenido, string Resultado)
        {
            this.titulo = Titulo;
            this.contenido = Contenido;
            this.result = Resultado;
        }
    }
}
