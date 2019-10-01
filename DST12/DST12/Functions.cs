using System.Linq;
using System;
using System.Collections.Generic;
//using ConsoleTables;
using System.Text;

namespace DST12
{
    class Functions : IFunction
    {
       
            
        private List<Item> itemList;
        private List<BoughtItems> boughtList;
        public Functions(List<Item> itemList)
        {
                this.itemList = itemList;
        }
        public Functions(List<BoughtItems> boughtList)
        {
            this.boughtList = boughtList;
        }
        public void AddItem()
            {

                Console.Write("Product Code: ");
                string code = Console.ReadLine();
                Console.Write("Product Name: ");
                string name = Console.ReadLine();
                Console.Write("Product Price: ");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.Write("Product Stock: ");
                int stock = Convert.ToInt32(Console.ReadLine());

                Item b = new Item(code, name, price, stock);
                itemList.Add(b);
                Console.WriteLine("Successfully Added");
            }
            public void BuyItem()
            {
                Console.Write("Product Code: ");
                string buyCode = Console.ReadLine();

                Item searchItem = itemList.Where(x => x.pcode == buyCode).FirstOrDefault();
                if (searchItem != null)
                {
                    Console.Write("Product Quantity: ");
                    int buyStock = Convert.ToInt32(Console.ReadLine());

                    if (searchItem.pstock >= buyStock)
                    {
                        searchItem.BuyItem(buyStock);
                        BoughtItems obj = new BoughtItems(searchItem.pcode, searchItem.pname, searchItem.pprice, buyStock);
                        boughtList.Add(obj);
                        Console.WriteLine("Successfully Product Bought");
                    }
                    else
                    {
                        Console.WriteLine("Sorry given quantity is not available on stock");
                    }

                }
                else
                {
                    Console.WriteLine("Item not Found");
                }

            }
      
            public void DisplayItem()
            {
               /* var table = new ConsoleTable("Code", "Name", "Price", "Remaining Stock");

                foreach (var item in itemList)
                {
                    table.AddRow(item.pcode, item.pname, item.pprice, item.pstock);
                }
                table.Write();
                */
            }
            

            public void DisplayBoughtItem()
            {
            Console.WriteLine("Code      Name      Price      Remaining Stock");
            foreach (var item in boughtList)
            {
                Console.Write(item.pcode);
                Console.Write("      ");
                Console.Write(item.pname);
                Console.Write("       ");
                Console.Write(item.pprice);
                Console.Write("       ");
                Console.Write(item.pstock);

                Console.WriteLine();
            }
        }

            public void TotalPrice()
            {

            }


    }

   
}
