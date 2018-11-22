using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{

    interface IShopBaseMethodOne
    {
        //void Add(Object obj);
        //void Remove(Object obj);
        void Add();
        void Remove();
    }

    interface IShopBaseMethodSecond
    {
        void Show();
        void Update();
    }

    interface IMixable : IShopBaseMethodOne, IShopBaseMethodSecond
    {

    }
   
    class Program
    {
        static public void ShowMenu()
        {
            Console.WriteLine("Add[1], Remove[2], Update[3], Show[4], Exit[5]");
        }   
        
        static public int GetObj()
        {
            int maxItem = 4, minItem = 0;
            Console.WriteLine("Which object: Section[1], Category[2], Book[3]");
            if (int.TryParse(Console.ReadLine(), out int choose))
            {
                if (choose >minItem && choose < maxItem)
                {
                    return choose;
                }
            }
            return -1;
        }

        static void DoAction(IMixable obj, int act)
        {
            if(act ==1)
            {
                obj.Add();
            }
            else if (act ==2)
            {
                obj.Remove();
            }
            else if (act == 3)
            {
                obj.Update();
            }
            else if (act == 4)
            {
                obj.Show();
            }
        }
        static void Main(string[] args)
        {
            int action = 1;
            int selectedObj = 0;
            Shop shop = new Shop();

            while (action != 5)
            {
                ShowMenu();
                if (int.TryParse(Console.ReadLine(), out action))
                {
                    if (shop.CountSection > 0)
                    {
                        if (action > 0 && action <5)
                        {
                            if ((selectedObj=GetObj()) !=-1)
                            {
                                if (action==3  && selectedObj != 3)
                                {
                                    selectedObj++;
                                }
                                IMixable obj = (IMixable)shop;
                                if (selectedObj == 2)
                                {
                                    obj = (IMixable)shop.GetSection();
                                }
                                else if (selectedObj == 3)
                                {
                                    obj = (IMixable)shop.GetCategory();
                                }
                                DoAction(obj, action);
                            }
                        }
                    }                        
                  }
                else
                {
                    Console.WriteLine("You haven\'t any section. Create new (y/n)?");
                    if (Console.ReadKey(true).KeyChar == 'y')
                    {
                        shop.Add();
                    }
                }
            }
        }
    }
}
