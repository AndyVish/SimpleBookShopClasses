using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    abstract class CommonShopObject : IMixable
    {
        protected string name;
        protected static int id;

        public virtual void Update()
        {
            Console.WriteLine("Enter new name ->");
            string tmp_name = Console.ReadLine();
            if (tmp_name.Trim() != "")
            {
                name = tmp_name;
            }
        }

        public virtual int CheckInput(int countObj)
        {
            int exit = 1;
            int choose = -1;
            while (exit == 1)
            {
                if (int.TryParse(Console.ReadLine(), out choose))
                {
                    if (choose >= 0 && choose <= countObj)
                    {
                        exit = 0;
                        choose--;
                    }
                    else
                    {
                        Console.WriteLine("Entered uncorrect number. Try again? (y/n)", countObj);
                        if (Console.ReadLine() == "n")
                        {
                            exit = 0;
                            choose = -1;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Entered uncorrect number. Try again? (y/n)");
                    if (Console.ReadLine() == "n")
                    {
                        exit = 0;
                        choose = -1;
                    }
                }
            }

            return choose;
        }

        public string Name { get { return name; } }
        public abstract void Show();
        public abstract void Add();
        public abstract void Remove();

    }
}
