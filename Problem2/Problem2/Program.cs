using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,rem,reverse=0;
            Console.Write("Please give a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            while (num!= 0)
            {
                rem = num% 10;
                reverse = (reverse* 10) + rem;
                num/= 10;
            }
            Console.Write("Result is: " + reverse);
            num = reverse;
            int flag = 0;
            int  m = Convert.ToInt32(Math.Sqrt(num));
            for (int i = 2; i <= m; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(" (Not Prime)");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine(" (Prime)");
        }
    }
}
