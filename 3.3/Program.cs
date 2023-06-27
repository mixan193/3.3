using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isAccepted = false;
            int n;
            Console.WriteLine("Введите число");
            while (!isAccepted)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    isAccepted = true;
                    if (isPrime(n))
                    {
                        Console.WriteLine("Число простое");
                    }
                    else
                    {
                        Console.WriteLine("Число не является простым");
                    }
                }
                finally
                {
                    Console.ReadKey();
                }
            }
        }
        
        private static bool isPrime(int n)
        {
            if (n == 0 || n == 1) 
            {
                return false;
            }
            for(int i = 2; i < n - 1; i++)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
