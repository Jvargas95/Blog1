using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog1
{
    class login
    {
        string usuario, contraseña;

        public void Login()
        {
            Console.WriteLine("-------------------------LOGIN---------------------");
            Console.WriteLine("Ingrese el usuario:");
            usuario = (Console.ReadLine());
            Console.WriteLine("Ingresa la contraseña");
            contraseña = (Console.ReadLine());
            Console.Clear();
        }

        public void procedimiento()
        {
            if (usuario.Equals("Josseling") && contraseña.Equals("12345"))
            {
                Console.WriteLine("Bienvenido\t" + usuario);
            }
            else
            {
                Console.WriteLine("Acceso Denegado");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.ReadKey();
            Console.Beep();
        }
    }
}
