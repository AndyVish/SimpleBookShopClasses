using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{

    interface IShopBaseMethodOne
    {
        void Add(Object obj);
        void Remove(Object obj);
    }

    interface IShopBaseMethodSecond
    {
        void Show();
        void Update();
    }

    class Program
    {
        static public void ShowMenu()
        {
            Console.WriteLine("Add[1], Remove[2], Update[3], Show[4], Exit[5]");
        }

        static void Main(string[] args)
        {
            string exit = "1";
            Shop shop = new Shop();

            while (exit != "5")
            {
                //Console.WriteLine("\t\t====== {0} ======", shop.Name);
                ShowMenu();

                exit = Console.ReadLine();
                string choose = "";
                if (exit != "5")
                {
                    if (shop.CountSection > 0)
                    {
                        switch (exit)
                        {
                            case ("1"):
                                Console.WriteLine("What add: Section[1], Category[2], Book[3]");
                                choose = Console.ReadLine();
                                if (choose == "1")
                                {
                                    shop.Add();
                                }
                                else if (choose == "2")
                                {
                                    shop.AddCategory();
                                }
                                else if (choose == "3")
                                {
                                  //  shop.AddBook();
                                }
                                break;
                            case ("2"):
                                //Console.WriteLine("Remove");
                                Console.WriteLine("What remove: Section[1], Category[2], Book[3]");
                                choose = Console.ReadLine();
                                if (choose == "1")
                                {
                                   // shop.Remove();
                                }
                                else if (choose == "2")
                                {
                                    shop.RemoveCategory();
                                }
                                else if (choose == "3")
                                {
                                   // shop.AddBook();
                                }
                                break;

                            case ("3"):
                                //Console.WriteLine("Update");
                                //Console.WriteLine("What show: Section[1], Category[2], Book[3]");
                                //choose = Console.ReadLine();
                                //if (choose == "1")
                                //{
                                //    shop.ShowSectionList();
                                //}
                                //else if (choose == "2")
                                //{
                                //    shop.ShowCategory();
                                //}
                                //else if (choose == "3")
                                //{
                                //    //shop.AddBook();
                                //}
                                
                                break;

                            case ("4"):
                                Console.WriteLine("What show: Section[1], Category[2], Book[3]");
                                choose = Console.ReadLine();
                                if (choose == "1")
                                {
                                    shop.ShowSectionList();
                                }
                                else if (choose == "2")
                                {
                                    shop.ShowCategory();
                                }
                                else if (choose == "3")
                                {
                                    //shop.AddBook();
                                }
                                break;
                            default:
                                //shop.ShowSectionList();
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You havent any section. Create new (y/n)?");
                        if (Console.ReadKey(true).KeyChar == 'y')
                        {
                            //Section section = new Section();
                            shop.Add();
                        }
                    }



                }
            }
        }
    }
}
