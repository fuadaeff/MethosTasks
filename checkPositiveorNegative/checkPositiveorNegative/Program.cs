namespace checkPositiveorNegative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static string check(int a)
            {
                if (a < 0)
                {
                    return "Negative";
                }
                else if (a > 0)
                {
                    return "Positive";
                }
                else
                {
                    return "Zero";
                }
            }
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(check(number));

        }
    }
}
