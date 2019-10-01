using System;
using System.Collections;
using System.Collections.Generic;

namespace DST12
{
    class Program
    {
        static void Main(string[] args)
        {

            var itemList = new List<Item>();
            IFunction obj = new Functions(itemList);
            Console.WriteLine("Welcome to ABC-Ecommerce System");
            Console.WriteLine("Please select an option:");
            void OptionMessage()
            {
                Console.Write("1: ADD PRODUCT TO STORE\n2: SHOW PRODUCT LIST OF STORE\n3: BUY PRODUCT\n4: SHOW ALL BOUGHT PRODUCT LIST\n5: SHOW TOTAL PRICE OF ALL BOUGHT PRODUCT\n6: EXIT");

            }
            while (true)
            {

                OptionMessage();
                Console.Write("\nPlease Select an Option :");

                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    obj.AddItem();
                }
                else if (option == 3)
                {
                    obj.BuyItem();
                }
                else if (option == 2)
                {
                    obj.DisplayItem();
                }
                else if (option == 4)
                {
                    obj.DisplayBoughtItem();
                }
                else if (option == 5)
                {
                    obj.TotalPrice();
                }
                else
                {
                    break;
                }
                Console.WriteLine("======================================");

            }
            Console.WriteLine("Thank You for using ABC-Ecommerce System");
        }
    }
        }
   
