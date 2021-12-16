using System;

namespace yether
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int i = 2, j;
            int sayac;
            while (i < sayi)
            {
                sayac = 0;
                j = 2;
                while (j < i)
                {
                    if (i % j == 0)
                    {
                        sayac++;
                    }
                    j++;
                }
                if (sayac == 0)
                {
                    Console.WriteLine("Prime Numbers = " + i);
                }
                i++;
            }
            Console.ReadLine();
        }
    }
}
