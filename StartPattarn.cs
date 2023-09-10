namespace StarPattarn2
{
    internal class StartPattarn
    {
        static void Main(string[] args)
        {
            int rows = 7;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (i > 0 && i < rows - 1 && j > 0 && j < rows - 1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                    Console.WriteLine();
                }
            }
        }
    }
