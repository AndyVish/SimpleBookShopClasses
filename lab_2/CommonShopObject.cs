using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    abstract class CommonShopObject : IShopBaseMethodSecond
    {
        protected string name;
        protected static int id;

        public virtual void Show()
        {
            Console.WriteLine(name);
        }
        public virtual void Update()
        {
            Console.WriteLine("Enter name");
            string tmp_name = Console.ReadLine();
            if (tmp_name.Trim() != "")
            {
                name = tmp_name;
            }
        }
    }
}
