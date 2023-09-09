namespace SumOfDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            long N = 8999068681;
            long rem, sum = 0;
            while (N !=0)
            {
                rem = N % 10;
                sum = sum + rem;
                N = N / 10;
            }

            Console.WriteLine("Sum of Digits are: " + sum);
        }
    }
}