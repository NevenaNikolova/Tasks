using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TribonacciTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //dava 60/100; ima vtoro otdolu

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());

            List<int> tribonacci = new List<int>
            {
                a,
                b,
                c
            };

            int tribonacciCount = 0;

            for (int i = 1; i <= lines; i++)
            {
                tribonacciCount += i;
            }

            for (int i = 3; i < tribonacciCount; i++)
            {
                int current = a + b + c;
                
                tribonacci.Add(current);
                a = b;
                b = c;
                c = current;
            }

            //Console.WriteLine(String.Join(" ", tribonacci));

            int index = 0;
            for (int row = 0; row < lines; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    Console.Write(tribonacci[index]);
                    if (index!=tribonacciCount-1)
                    {
                        Console.Write(" ");
                    }
                    index++;
                }               
                Console.WriteLine();
            }
        }
    }
}
static void Main()
{
    long first = long.Parse(Console.ReadLine());
    long second = long.Parse(Console.ReadLine());
    long third = long.Parse(Console.ReadLine());

    byte L = byte.Parse(Console.ReadLine());

    for (int i = 0; i < L; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            long newNum = first + second + third;

            if (j > 0)
            {
                Console.Write(' ');
            }

            Console.Write(first);

            first = second;
            second = third;
            third = newNum;
        }

        Console.WriteLine();
    }
}