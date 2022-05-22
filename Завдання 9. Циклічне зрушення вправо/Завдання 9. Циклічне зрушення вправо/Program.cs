using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Завдання 9. Циклічне зрушення вправо


namespace Task9
{
    internal class Array
    {
        static void Main()
        {
            int N = 0 ;
            string str = Console.ReadLine();

            N = Convert.ToInt32(str);
            int[] array = new int[N];


            array = Console.ReadLine().Split().Select(int.Parse).ToArray();


            int t = array[array.Length - 1];

            for (int i = 0; i < array.Length; i++)
            {
                int t2 = array[i];
                array[i] = t;
                t = t2;
                
            }
            for (int i = 0; i < N; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}