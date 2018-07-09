using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Indices
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse).ToArray();

            StringBuilder sequence = new StringBuilder();

            long currentIndex = 0;

            while (true)
            {
                if (currentIndex < 0 || currentIndex >= n)
                {
                    break;
                }

                Match match = Regex.Match(sequence.ToString(), currentIndex.ToString());
                if (match.Success)
                {
                    sequence.Replace(' ', ')', sequence.Length - 1, 1);
                    sequence.Insert(match.Index - 1, "(");
                    sequence.Remove(match.Index, 1);
                    break;
                }
                else
                {
                    sequence.Append(currentIndex);
                    sequence.Append(" ");
                }
                currentIndex = numbers[currentIndex];
            }
            Console.WriteLine(sequence.ToString().TrimEnd());

        }
    }
}
