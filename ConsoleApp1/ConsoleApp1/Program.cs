using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            ///var item = (Name: "eggplant", Price: 1.99m, perPackage: 3);
            ///var date = DateTime.Now;
            ///Console.WriteLine($"On {date}, the price of {item.Name} was {item.Price:C2} per {item.perPackage} items.");
            /*object a = 10.5;
            dynamic b = 5.2;
            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());*/
            /*string name = "Dev Skill";
            if(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("No name");
            }
            else Console.WriteLine(name);
            */
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
