namespace CountNumber
{
    internal class CountNum
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            int[] num = { 1, 2, 5, 12, 43, 54, 12, 43, 2, 9, 7 };
            for(int i=0;i<num.Length;i++) 
            {
                for(int j=i+1;j<num.Length;j++)
                {
                    if (num[i] == num[j])
                    {
                        Console.WriteLine("duplicate number is: " + num[i]);
                        cnt++;
                    }
                }
            }
            Console.WriteLine("Total number of duplicate element are: " + cnt);
        }
    }
}