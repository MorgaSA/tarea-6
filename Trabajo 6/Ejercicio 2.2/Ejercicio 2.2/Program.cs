using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int N = 50, c = 0;
        static string[] arreglo = new string[N];
        static string Nombre, temp;
        static void incercion()
        {
            if (c >= N)
            {
                Console.WriteLine("Arreglo lleno");
            }
            else
            {
                Console.WriteLine("Cual es el nombre");
                Nombre = Console.ReadLine();
                arreglo[c] = Nombre;
                c = c + 1;
            }
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
        }
        static void impresion()
        {
            
            Console.WriteLine("Los nombres son");
            for (int b = 0; b < c; b++)
            {
                Console.WriteLine(arreglo[b]);
            }
            Console.ReadLine();
            Console.Clear();
        }
        static void BBinaria(string NomABuscar)
        {
            int Li = 0, Ls = c, B = 0;
            
            while (Li < Ls && B == 0)
            {
                
                int mitad = (Li + Ls) / 2;
                Console.WriteLine(arreglo[mitad]);
                if (arreglo[mitad].CompareTo(NomABuscar) == 0)
                {
                    B = 1;
                }
                else
                {
                    if (arreglo[mitad].CompareTo(NomABuscar) < 0)
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
        }
        static void Main(string[] args)
        {
            int op;
            string dato;
            do
            {
                Console.WriteLine("Que desea hacer: \n1.Incertar Nombre \n2.Imprimir lista de nombres \n3.Buscar nombre de forma binaria \n4.Salir");
                op = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1:
                        incercion();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        impresion();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Que nombre desea buscar");
                        dato = Console.ReadLine();
                        BBinaria(dato);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        break;
                    default:
                        Console.Write("\nOpcion invalida");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            } while (op != 4);
        }
    }
}
