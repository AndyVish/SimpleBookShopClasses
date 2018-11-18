using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    abstract class Item : IShopBaseMethodSecond
    {
        protected int id;
        protected string itemName;
        protected double price;

        
        virtual public void Show()
        {
            Console.WriteLine("{0}, {1}", itemName, price);
        }
        public void Update()
        {
            Console.WriteLine("Enter name");
            string tmp_name = Console.ReadLine();
            if (tmp_name.Trim() != "")
            {
                itemName = tmp_name;
            }
        }
    }
}
