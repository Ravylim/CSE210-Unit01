using System;
using System.Collections.Generic;

namespace solo_prep_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enetr the list of numbers, type 0 when finish.");

            int number = -1; 
            while (number != 0)
            {
                Console.Write("Enter the number: ");
                int num = int.Parse(Console.ReadLine());
                if (num != 0 )
                {
                    numbers.Add(num);
                }
                else 
                {
                    break;
                }
            }
           int sum = 0 ;
           foreach (int num in numbers)
           {
               sum += num;
           }
            Console.WriteLine($"The sum is: {sum}");

            float average = sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            int max = -999999;
            foreach (int num in numbers )
            {
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine($"The max is: {max}");
        }
}
}