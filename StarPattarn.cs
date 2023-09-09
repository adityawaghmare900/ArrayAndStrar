namespace StarPattarn
{
    internal class StarPattarn
    {
        static void Main(string[] args)
        {
            for (int i = 8; i >= 0; i--)
            {
                for (int j = i; j >= 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}