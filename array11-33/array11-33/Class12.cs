using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Завдання 12. Шеренга

namespace array11_33
{
    internal class Class12
    {
        public static void main()
        {
            int N = 0, Petro = 0, a = 1;

            N = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[N];
            array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Petro = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                if (Petro > array[i])
                {
                    break;
                }
                else a++;
            }

            Console.WriteLine(a);
        }
    }
}