using System.Xml.Linq;

namespace SumOfMatrix
{
    internal class SumOfMatrix
    {
        static void Main(string[] args)
        {
            int row, col;
            int sum=0;
            Console.WriteLine("Enter No. of rows of array");
            row=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter No. of col of array");
            col=Convert.ToInt16(Console.ReadLine());
            int[,] matrix=new int[row,col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("enter value: " + (i * col + j) + ": ");
                    matrix[i,j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            for (int i=0; i<4; i++)
            {
                for(int j = 0;j < 4; j++)
                {
                    sum = sum + matrix[i,j];
                }
                Console.WriteLine(sum);
                sum = 0;
            }
        }
    }
}