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
        int opcion;

        public void Login()
        {
            Console.WriteLine("-------------------------LOGIN---------------------");
            Console.WriteLine("Ingrese el usuario:");
            usuario = (Console.ReadLine());
            Console.WriteLine("Ingresa la contraseña");
            contraseña = (Console.ReadLine());
            Console.WriteLine("Ingresa 1 si es escritor o 0 si es lector");
            opcion = int.Parse((Console.ReadLine()));
            Console.Clear();
        }

        public int procedimiento()
        {
            int validado=0;
            if(opcion==1)//si es escritor
            {
                if (usuario.Equals("Josseling") && contraseña.Equals("12345"))
                {
                    validado = 1;
                    Console.WriteLine("Bienvenido\t" + usuario);
                }
                else
                {
                    validado = 0;
                    Console.WriteLine("Acceso Denegado");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                Console.ReadKey();
                Console.Beep();
            }else if(opcion==0)//si es lector
            {
                if (usuario.Equals("Josseling") && contraseña.Equals("12345"))
                {
                    validado = 2;
                    Console.WriteLine("Bienvenido\t" + usuario);
                }
                else
                {
                    validado = 0;
                    Console.WriteLine("Acceso Denegado");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                Console.ReadKey();
                Console.Beep();
            }
            else
            {
                validado = 0;
                Console.WriteLine("Rol no valido del " + usuario);
                Console.ReadKey();
                Console.Beep();

            }
            return validado;
        }
    }
}
