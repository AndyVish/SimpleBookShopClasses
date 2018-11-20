using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    class Shop
    {
        int countSection;
        List<Section> sectionList;
        
        public Shop()
        {
            countSection = 0;
            sectionList = new List<Section>();
        }

        public int CountShop { get { return countSection; } }
        public int CountSection{ get { return countSection; } }

        public void Add()
        {
            var section = new Section();
            section.Update();
            sectionList.Add(section);
            countSection++;
        }

        public void AddCategory()
        {
            int lenListSection = ShowSectionList();
            Console.WriteLine("Choose number of section ->");
            var userChoose = CheckInput(lenListSection);

            if (userChoose != -1)
            {
                
                sectionList[userChoose].CategoryAdd();
                
            }
        }

        public void AddBook()
        {

        }

        public void Remove(Section section) {
            sectionList.Remove(section);
            countSection++;
        }

        public int ShowSectionList()
        {
            int i = 0;
            foreach (var item in sectionList)
            {
                i++;
                Console.Write($"{i})");
                item.Show();
            }
            return i;
        }

        public int CheckInput(int countObj)
        {
            int exit = 1;
            int  choose=-1;
            while (exit == 1)
            {
                if (int.TryParse(Console.ReadLine(), out choose))
                {
                    if (choose >= 0 && choose <= countObj)
                    {
                        exit = 0;
                    }
                    else
                    {
                        Console.WriteLine("Entered uncorrect number. Try again? (y/n)", countObj);
                        if (Console.ReadLine() == "n")
                        {
                            exit = 0;
                            choose =  -1;
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
               
    }

} 
