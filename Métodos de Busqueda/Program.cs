using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos_de_Busqueda
{
    class Program
    {
        static void Main(string[] args)
        {
            MétodosBusqueda metodos = new MétodosBusqueda();
            

            int opt;

            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 21, 30, 49, 51, 63, 64, 80, 100, 552, 1864, 2149 };

            Hash hash = new Hash(array.Length);

            while (true)
            {
                Console.WriteLine("\nArreglo actual:");
                metodos.print(array);

                Console.WriteLine("\n=== Menú de Búsqueda y Hashtable ===");
                Console.WriteLine("1. Búsqueda Secuencial (Desordenada)");
                Console.WriteLine("2. Búsqueda Binaria");
                Console.WriteLine("3. Agregar Arreglo A Hashtable");
                Console.WriteLine("4. Mostrar Hashtable");
                Console.WriteLine("5. Buscar en Hashtable");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");
                opt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                
                

                switch (opt)
                {
                    case 1:
                        Console.Write("Ingrese el valor a buscar: ");
                        int valSeq = Convert.ToInt32(Console.ReadLine());
                        metodos.Secuential_unordered(array, valSeq);
                        break;

                    case 2:
                        Console.Write("Ingrese el valor a buscar: ");
                        int valBin = Convert.ToInt32(Console.ReadLine());
                        metodos.Binary(array, valBin);
                        break;

                    case 3:
                        int clave = 0;
                        foreach (var valor in array)
                        {
                            hash.Insert(clave, valor);
                            clave++;
                        }
                        break;

                    case 4:
                        hash.DisplayTable();
                        break;

                    case 5:
                        Console.Write("Ingrese la clave a buscar: ");
                        int keySearch = Convert.ToInt32(Console.ReadLine());
                        hash.Get(keySearch);
                        break;                                   
                    case 6:
                        Console.WriteLine("Adios");
                        return;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;

                }
            }
        }
    }
}
