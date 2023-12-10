using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Sort5Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numbers = new HashSet<int>();
            Console.WriteLine("Enter 5 unique numbers:");

            while (numbers.Count < 5)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("You have already entered this number. Please enter a different number.");
                    }
                    else
                    {
                        numbers.Add(number);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            var sortedNumbers = new List<int>(numbers);
            sortedNumbers.Sort();

            Console.WriteLine("Sorted numbers:");
            foreach (int num in sortedNumbers)
            {
                Console.WriteLine(num);
            }

        }
    }
}
