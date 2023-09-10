namespace FrequecyOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 3, 4, 2, 2, 1, 5, 6, 6, 2, 3 };
            int[] freq = new int[arr.Length];
            int visited = -1;
            int cnt;
            for (int i = 0; i < arr.Length; i++)
            {
                cnt = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        cnt++;
                        freq[j] = visited;
                    }

                    if (freq[i] != visited)
                    {
                        freq[i] = cnt;
                    }
                }
                }
            Console.WriteLine("Element    frequency ");

            for (int i = 0; i < freq.Length; i++)
                {
                    if (freq[i] != visited)
                    {
                        Console.WriteLine("   "+arr[i]+"         " + freq[i]);
                    }

                }
            }
        }
    }
