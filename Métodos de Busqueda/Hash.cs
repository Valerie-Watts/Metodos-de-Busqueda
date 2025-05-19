using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos_de_Busqueda
{
    class Hash
    {       
        private int size;
        private List<(int key, int value)>[] table;

        public Hash(int size)
        {
            this.size = size;
            table = new List<(int, int)>[size];
            for (int i = 0; i < size; i++)
            {
                table[i] = new List<(int, int)>();
            }
        }

        public void Insert(int key, int value)
        {
            int index = HashModule(key);
            for (int i = 0; i < table[index].Count; i++)
            {
                if (table[index][i].key == key)
                {
                    table[index][i] = (key, value);
                    Console.WriteLine($"Updated key={key} with value={value}");
                    return;
                }
            }
            table[index].Add((key, value));
            Console.WriteLine($"Inserted key={key}, value={value}");
        }

        public void Get(int key)
        {
            int index = HashModule(key);
            foreach (var pair in table[index])
            {
                if (pair.key == key)
                {
                    Console.WriteLine($"Found key={key} with value={pair.value}");
                    return;
                }
            }
            Console.WriteLine($"Key {key} not found");
        }

        private int HashModule(int key)
        {
            return key % size;
        }

        public void DisplayTable()
        {
            Console.WriteLine("\nHash Table Contents:");
            for (int i = 0; i < size; i++)
            {
                Console.Write("Index " + i + ": ");
                if (table[i].Count == 0)
                {
                    Console.WriteLine("Empty");
                }
                else
                {
                    foreach (var pair in table[i])
                    {
                        Console.Write($"[Key: {pair.key}, Value: {pair.value}] ");
                    }
                    Console.WriteLine();
                }
            }
        }
        public void PrintArray(int[] arr)
        {
            Console.WriteLine("Array contents: [" + string.Join(", ", arr) + "]");
        }
    }




}
