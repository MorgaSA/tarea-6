using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 50, c = 0, i;
            string[] arreglo = new string[N];
            string condicion, Nombre, temp;
            
            Console.WriteLine("Desea incertar un Nombre [si], [no]");
            condicion = Console.ReadLine();
            do
            {
                if (condicion == "no")
                {
                    Console.WriteLine("Muchas gracias");
                    if (c == 0)
                    {
                        Console.WriteLine("Pila vacia");
                    }
                }
                else
                {
                    if (c >= N)
                    {
                        Console.WriteLine("Pila llena");
                    }
                    else
                    {
                        if (c == 0)
                        {
                            Console.WriteLine("Pila vacia");
                        }
                        Console.WriteLine("Cual es el nombre");
                        Nombre = Console.ReadLine();
                        arreglo[c] = Nombre;

                    }
                    Console.WriteLine("Desea otra incersion [si], [no]");
                    condicion = Console.ReadLine();
                    Console.Clear();
                    c = c + 1;
                }
            }

            while (condicion != "no");
            Console.WriteLine("   ");
            
            Console.WriteLine("Los nombres son");            
            for (int b = 0; b < c; b++)
            {
                Console.WriteLine(arreglo[b]);
            }
            Console.ReadLine();            
            Console.Clear();
            
            //busqueda
            Console.WriteLine("Busqueda secuencial \n que nombre quiere buscar");
            string NomABuscar;
            int pos = 0,B = 0;
            NomABuscar = Console.ReadLine();
            do
            { 
                while(pos < c && B == 0)
                {
                    if (arreglo[pos].CompareTo(NomABuscar) == 0)
                    {
                        B = 1;
                    }
                    else
                    {
                        pos = pos + 1;
                    }
                }
                if (B == 0)
                {
                    Console.WriteLine("No esta " + NomABuscar);
                    for (int b = 0; b < c; b++)
                    {
                        Console.WriteLine(arreglo[b]);
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine(" si esta " + NomABuscar);
                    for (int b = 0; b < c; b++)
                    {
                        Console.WriteLine(arreglo[b]);
                    }
                    Console.WriteLine("Desea otra busqueda [si],[no]");
                    condicion = Console.ReadLine();
                    Console.Clear();
                }
            } while (condicion != "no");
        }
    }
}
