using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] ara = new int[100,100];
            int N,sum1=0,sum2=0;
            N = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<N;i++)
                for (int j = 0; j < N; j++)
                {
                    ara[i,j]= Convert.ToInt32(Console.ReadLine());
                }
            for(int i = 0; i < N; i++)
            {
                sum1 += ara[i,i];
            }
            int k = N - 1;
            for (int i = 0; i<N ; i++)
            {
                sum2 += ara[i,k];
                k--;
            }
            Console.WriteLine("Left Diagonal Sum is: " + sum1 + " Right Diagonal Sum is: " + sum2);
        }
    }
}
