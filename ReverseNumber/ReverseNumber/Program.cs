namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int reverse(int number)
            {
                int q = 0;
                int reversedNumber = 0;
                if (number < 0)
                {
                    number = -number;
                    while (number > 0)
                    {
                        q = number % 10;
                        number = number / 10;
                        reversedNumber = (reversedNumber * 10) + q;
                    }
                    return -reversedNumber;
                }
                else
                {
                    while (number > 0)
                    {
                        q = number % 10;
                        number = number / 10;
                        reversedNumber = (reversedNumber * 10) + q;
                    }
                    return reversedNumber;
                }
            }
            Console.WriteLine("Enter a number:");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(reverse(input));
        }
    }
}
