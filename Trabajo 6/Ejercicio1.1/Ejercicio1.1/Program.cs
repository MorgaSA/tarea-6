using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static  int N = 50, c = 0;        
        static string[] arreglo = new string[N];
        static void incercion()
        {                
            string Nombre;
                    if (c >= N)
                    {
                        Console.WriteLine("arreglo lleno");
                    }
                    else
                    {
                        Console.WriteLine("Cual es el nombre");
                        Nombre = Console.ReadLine();
                        arreglo[c] = Nombre;
                        c = c + 1;
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
        static void BSecuencial(string NomABuscar)
        {
            int pos = 0, B = 0;
            while (pos < c && B == 0)
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
                Console.WriteLine("Que desea hacer: \n1.Incertar Nombre \n2.Imprimir lista de nombres \n3.Buscar nombre de forma secuencial \n4. salir");
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
                        BSecuencial(dato);
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
