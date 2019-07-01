using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] smonth = new string[12] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            int year, day, month;
            Y:
            Console.Write("Please enter year:");
            year = Convert.ToInt32(Console.ReadLine());
            if (year > 2019 || year < 1971)
            {
                Console.WriteLine("Sorry, you provide an invalid year. Try again!");
                goto Y;
            }
            M:
            Console.Write("Please enter month:");
            month = Convert.ToInt32(Console.ReadLine());
            if (month > 12)
            {
                Console.WriteLine("Sorry, you provide an invalid month. Try again!");
                goto M;
            }
            D:
            Console.Write("Please enter day:");
            day= Convert.ToInt32(Console.ReadLine());
            if (day <1 || day>31)
            {
                Console.WriteLine("Sorry, you provide an invalid day. Try again!");
                goto D;
            }
            switch (month)
            {
                case 2:
                    if (day > 28)
                    {
                        Console.WriteLine("Sorry, you provide an invalid day. Try again!");
                        goto D;
                    }
                    break;
                case 4:
                    if (day > 30)
                    {
                        Console.WriteLine("Sorry, you provide an invalid day. Try again!");
                        goto D;
                    }
                    break;
                case 6:
                    if (day > 30)
                    {
                        Console.WriteLine("Sorry, you provide an invalid day. Try again!");
                        goto D;
                    }
                    break;
                case 9:
                    if (day > 30)
                    {
                        Console.WriteLine("Sorry, you provide an invalid day. Try again!");
                        goto D;
                    }
                    break;
                case 11:
                    if (day > 30)
                    {
                        Console.WriteLine("Sorry, you provide an invalid day. Try again!");
                        goto D;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine("Your Date is: " + day + "-"+smonth[month-1]+"-"+year%100);
        }
    }
}
