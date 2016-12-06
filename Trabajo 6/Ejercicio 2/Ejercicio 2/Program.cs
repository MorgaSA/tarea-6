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
            //Ordenamiento
            for (int a = 0; a < c; a++)
            {
                for (int b = a + 1; b < c; b++)
                {
                    if (arreglo[a].CompareTo(arreglo[b]) > 0)
                    {
                        temp = arreglo[a];
                        arreglo[a] = arreglo[b];
                        arreglo[b] = temp;

                    }

                }
            }
            Console.WriteLine("Los nombres ordenados");            
            for (int b = 0; b < c; b++)
            {
                Console.WriteLine(arreglo[b]);
            }
            Console.ReadLine();            
            Console.Clear();
            
            //busqueda
            Console.WriteLine("  Busqueda binaria \nQue nombre quiere buscar");
            string NomABuscar;
            int Li = 0,Ls=c, B = 0;
            NomABuscar = Console.ReadLine();
            do
            {
                while (Li < Ls && B == 0)
                {
                    int mitad = (Li + Ls) / 2;
                    if (NomABuscar.CompareTo(arreglo[mitad]) == 0)
                    {
                        B = 1;

                    }
                    else
                    {
                        if (NomABuscar.CompareTo(arreglo[mitad]) > 0)
                        {
                            Li = mitad + 1;
                        }
                        else
                        {
                            Ls = mitad - 1;
                        }
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
                    Console.ReadLine();
                    Console.Clear();
                }
                Console.WriteLine("Desea otra busqueda [si], [no]");
                condicion = Console.ReadLine();
                Console.Clear();
            } while (condicion != "no");
        }
    }
}
