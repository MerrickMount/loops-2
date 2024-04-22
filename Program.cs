using System.ComponentModel;

namespace loops_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double testAmount, testScore, testPass;
            testPass = 0;
            Console.WriteLine("Welcome to the test checker");
            Console.WriteLine("Please enter how many test scores are being entered");
            testAmount = double.Parse(Console.ReadLine());
            for (double i = testAmount; i <= 0; i--)
            {
                Console.WriteLine("please input test score:");
                testScore = double.Parse(Console.ReadLine());
                if (testScore <= 70)
                {
                    testPass++;

                }
            }
            Console.WriteLine($"{testPass} of the tests were above 70%");
            Console.WriteLine($"that is a pass average of {testPass/testAmount}%");
        }
    }
}