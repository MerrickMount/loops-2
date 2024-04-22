using System.ComponentModel;

namespace loops_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testAmount, testScore, testPass;
            testPass = 0;
            Console.WriteLine("Welcome to the test checker");
            Console.WriteLine("Please enter how many test scores are being entered");
            testAmount = int.Parse(Console.ReadLine());
            for (int i = testAmount; i > 0; i--)
            {
                Console.WriteLine("please input test score:");
                testScore = int.Parse(Console.ReadLine());
                if (testScore <= 70)
                {
                    testPass++;
                    Console.WriteLine("Test Entered");
                }
                else
                {
                    Console.WriteLine("Test Entered");
                }
            }
            Console.WriteLine($"{testPass} of the tests were above 70%");
        }
    }
}