﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    

    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            Conexion s1 = Conexion.GetInstancia();
            Conexion s2 = Conexion.GetInstancia();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
        }
    }
}
