using System;
namespace solo_prep_2
{
    class Program
    {
        static void Main(string[] agrs)
        {
            Console.Write("What is the percentage of your grade? ");
            string userPercentage = Console.ReadLine();

            int percentage = int.Parse(userPercentage);

            if (percentage >= 90)
            {
                Console.WriteLine("You grade is A");
            }
            else if (percentage >= 80 && percentage < 90)
            {
                Console.WriteLine("You grade is B");
            }
            else if (percentage >= 70 && percentage < 80)
            {
                Console.WriteLine("You grade is C");
            }
            else if (percentage >= 60 && percentage < 70)
            {
                Console.WriteLine("You grade is D");
            }
            else
            {
                Console.WriteLine("You grade is F");
            }
            
            
            if (percentage >= 70)
            {
                Console.WriteLine("Congratulation, You passed");
            }
            else
            {
                Console.Write("Better luck next time");
            }
        }
    }
}
