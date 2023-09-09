namespace MaxAndMin
{
    internal class MaxAndMin
    {
        static void Main(string[] args)
        {
            int[] arr = { 13, 54, 23, 8, 73, 2, 5, 32, 59, 9, 10 };
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j=i+1; j<arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Maximum element in array is: " + arr[0]);
            Console.WriteLine("========================================");
            Console.WriteLine("Minumum element in array is: " + arr[arr.Length-1]);
        }
    }
}