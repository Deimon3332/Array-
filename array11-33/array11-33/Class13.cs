using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Завдання 13. Подвійний переворот


namespace array11_33
{
    internal class Class13
    {
        public static void main()
        {
            int j = 1;


            int[] a = new int[5];

            int[] array = new int[a[0]];

            array[0] = 1;
            
            for (int i = a[2]; i >= a[1]; i--)
            {
                array[j] = i;
                j++;
            }
            for (int i = a[4]; i >= a[3]; i--)
            {
                array[j] = i;
                j++;
            }

            for (int i = 0; i < a[0]; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}