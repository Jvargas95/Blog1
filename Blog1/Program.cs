﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog1
{
    class Program
    {
        static void Main(string[] args)
        {
            login inicio = new login();
            inicio.Login();
            inicio.procedimiento();
           
            Console.WriteLine("----------------------------BLOG------------------------");
            Console.WriteLine("--------------------------DEPORTES----------------------");
            deportes Deporte = new deportes("1--ATP CHAMPIONS TOUR", "\n2--Los 9 grandes tenistas que participarán en Mallorca y \n\tcon los que podremos disfrutar de este espectacular Legends CUP son: \n\tMark Philippoussis, Fernando González, Mats Wilander, Tim Henman, \n\tCarlos Moyá, Alex Carretja, Thomas Enqvist, Henri LeConte y Mikael Pernfors",
                                             "\n3--Resultado: 2-1");
            Console.WriteLine(Deporte.titulo + " " + Deporte.contenido + " " + Deporte.result);
            Console.WriteLine(Deporte.Tennis + "4--Babos T. (Hun) con Monova P. (Rus)");

            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
