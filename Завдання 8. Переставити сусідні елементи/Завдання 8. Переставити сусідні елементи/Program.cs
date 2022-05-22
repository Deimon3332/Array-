using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Завдання 8. Переставити сусідні елементи


namespace Task8
{
    internal class Array
    {
        static void Main()
        {
            int N = 0, j = 0;
            string str = Console.ReadLine();

            N = Convert.ToInt32(str);
            int[] array = new int[N];


            array = Console.ReadLine().Split().Select(int.Parse).ToArray();


            for (int i = 1; i < N; i+=2)
            {
                j = array[i];

                array[i] = array[i-1];

                array[i - 1] = j;
                
            }
            for (int i = 0; i < N; i++)
            {
                Console.Write(array[i] + " ");
            }


        }
    }
}