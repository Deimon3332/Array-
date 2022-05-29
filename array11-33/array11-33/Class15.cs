using System;
using System.Linq;


//Завдання 15. Кульки


namespace array11_33
{
    internal class Class15
    {
        public static void main()
        {
            int N = 0, counter = 0, temp = 0, counter1 = 1;

            N = Convert.ToInt32(Console.ReadLine());


            int[] array = new int[N];

            array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            temp = array[0];
            for (int i = 1; i < N; i++)
            {
                if (array[i] != temp)
                {
                    temp = array[i];
                    if (counter1 >= 3)
                    {
                        counter += counter1;
                    }
                    counter1 = 1;

                }
                else
                {
                    counter1++;
                }
            }

            if (counter1 >= 3)
            {
                counter += counter1;
            }

            Console.WriteLine(counter);
        }
    }
}