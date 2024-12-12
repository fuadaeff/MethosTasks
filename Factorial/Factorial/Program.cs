namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            static int Factorial(int number)
            {
                int fact = 1;
                for (int i = 1; i <= number; i++)
                {
                    fact = fact * i;
                }
                return fact;
            }
            Console.WriteLine("Enter a number:");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(input));
        }
    }
}
