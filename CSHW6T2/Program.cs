using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHW6T2
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            int nums;
            Console.WriteLine("Enter 10 numbers: \n");

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"Enter number {i+1} in range ({start}; {end}): ");
                    nums = ReadNumber(start, end);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Error.WriteLine("\n-> Error! Number was out of the range ({0}; {1})!\n", start, end);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("\n-> {0} -> {1}\n", e.GetType(), e.Message);
            }
            Console.ReadKey();
        }


        static int ReadNumber(int start, int end)
        {
            int number = int.Parse(Console.ReadLine());

            if (number <= start || number >= end);

            return number;
        }
    }
}
