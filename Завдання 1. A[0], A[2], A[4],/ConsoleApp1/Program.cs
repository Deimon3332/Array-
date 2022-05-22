using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

//Завдання 1. A[0], A[2], A[4], ...

namespace Task1
{
   internal class Array
    {
         static void Main()
        {
            int N = 0;
            string str = Console.ReadLine();
            
            N = Convert.ToInt32(str);
            int[] array = new int[N];


            array = Console.ReadLine().Split().Select(int.Parse).ToArray();


            for (int i = 0; i < N; i = i + 2)
            {
                
                    Console.Write(array[i] + " ");
            }
        }
    }
}