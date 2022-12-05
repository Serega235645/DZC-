using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        private const int V = 8;

        static void Main(string[] args)
        {
            int[] numbers = { 10, 54, 151, 25, 8, 34, 185 };
            int minNumber = numbers[0];
            int maxNumber = numbers[0];

            for (int i = 0; i < numbers.Length; i++){ 
                if (numbers[i] < minNumber){
                    minNumber = numbers[i];
                }
                if (numbers[i] > maxNumber){ 
                   maxNumber = numbers[i];
                }
            }
            Console.WriteLine(minNumber);
            Console.WriteLine(maxNumber);
        }
    }
}
