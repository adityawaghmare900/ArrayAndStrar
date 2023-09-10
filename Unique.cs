namespace AllUnique
{
    internal class Unique
    {
        static void Main(string[] args)
        {
            int cnt;
            int[] U = { 1, 3, 6, 3, 8, 4, 9, 3, 6, 3, 3, 2, 8, 5, 7 };
            Console.WriteLine("Unique elements are: ");
            for (int i = 0; i < U.Length; i++)
            {
                cnt = 0;
                for (int j =0; j < U.Length; j++)
                {
                    if (U[i] == U[j] && i!=j)
                    {
                        cnt++; 
                    }
                }
                if(cnt ==0 )
                {
                    Console.WriteLine(U[i]);
                }
            }
        }
    }
}