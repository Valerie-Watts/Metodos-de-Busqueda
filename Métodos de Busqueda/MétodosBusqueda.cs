using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Métodos_de_Busqueda
{
    class MétodosBusqueda
    {
        public void print(int[] array)
        {
            foreach (int k in array)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();
        }

        public void Binary(int[] array, int x)
        {
            

            int izq, cen, der;
            bool ban;
            int n = array.Length-1;

            izq = 0;
            der = n;
            ban = false;
            cen = 0;

            while ((izq <= der) && (ban == false))
            {
                cen = (izq + der) / 2;
                
                if (array[cen] == x)
                {
                    ban = true;
                }
                else
                {
                    if (x > array[cen])
                    {
                        izq = cen+1;
                    }
                    else
                    {
                        der = cen-1;
                    }
                }
                
            }
            print(array); 
            if (ban == true)
            {
                Console.WriteLine("The information is in the position: " + cen);
            }
            else
            { 
                Console.WriteLine("The information is not in the array");
            }
        }
        
        public void Secuential_unordered(int[]v, int x)
        {
            int i = 0;
            int n = v.Length - 1; 

            while ((i<=n) && (v[i]!= x))
            {
                i++;
            }
            if (i > n)
            {
                Console.WriteLine("The information is not in the array");           
            }
            else
            {
                print(v);
                Console.WriteLine("The information is in the position: " + i);
            }
        }

        
    }
}

