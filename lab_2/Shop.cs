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
            ShowSectionList();
            Console.WriteLine("Choose number of section ->");

        }

        public void AddBook()
        {

        }

        public void Remove(Section section) {
            sectionList.Remove(section);
            countSection++;
        }

        public void ShowSectionList()
        {
            int i = 1;
            foreach (var item in sectionList)
            {
                Console.Write($"{i})");
                item.Show();
            }
        }

        public int CheckInput(int countObj)
        {
            int exit = 1;
            int  choose;
            while (exit == 1)
            {
                if (int.TryParse(Console.ReadLine(), out choose))
                {
                    if (choose >= 0 && choose <= countObj)
                    {
                        return choose;
                    }
                    else
                    {
                        Console.WriteLine("Try again? (y/n)");
                        if (Console.ReadLine() == "n")
                        {
                            return -1;
                        }
                    }
                }
            }
        }
               
    }

} 
