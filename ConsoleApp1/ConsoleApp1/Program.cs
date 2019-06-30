using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "XYZ";
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Please Enter A Valid Name");
            }
            else
            {
                string msg = "Welcome to Professional Programming with C#";
                Console.WriteLine("Please Enter A Valid Name");
                ///Console.WriteLine(msg.Insert(0, "Hei," + name));
            }

            int a=10,b=20,s = 10;
            switch (s)
            {
                case 1:
                    Console.WriteLine("This is one");
                    break;
                default:
                    Console.WriteLine("This is 10");break;
            }

            int max = a > b ? a : b;
            int? age = null;
            int newAge = age ?? 20;
            string name = "OKA";
            Console.WriteLine(name.GetHashCode());

        }
    }
}
