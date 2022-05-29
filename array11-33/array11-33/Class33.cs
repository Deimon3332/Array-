using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Завдання 33. Кількість днів від початку ери


namespace array11_33
{
    internal class Class33
    {
        public static void main()
        {
            int  N = 0;
            DateTime A = new DateTime(1, 1, 1);

            try
            {
                N = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }
            DateTime Date = new DateTime(N % 10000, (N / 10000) % 100, N / 1000000 +1 );

            Console.WriteLine(Date.Subtract(A).Days);
        }
    }
}