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
            ///!!!!  countSection = 2; - origenal
            countSection = 2;
            sectionList = new List<Section>();

            sectionList.Add(new Section("Информационные технологии"));
            sectionList.Add(new Section("Ин-яз"));
                       
            Category k1 = new Category("Англ.");
            Category k2 = new Category("Фрфнц.");
            Category k3 = new Category("Итал.");
            sectionList[1].CategoryAdd(k1);
            sectionList[1].CategoryAdd(k2);
            sectionList[1].CategoryAdd(k3);


            Category k4 = new Category("С++");
            Category k5 = new Category("Сsharp.");
            sectionList[0].CategoryAdd(k4);
            sectionList[0].CategoryAdd(k5);


        }

        public int CountSection{ get { return countSection; } }


        //============= SECTION BEGIN============
        public void AddSection()
        {
            var section = new Section();
            section.Update();
            sectionList.Add(section);
            countSection++;
            Console.WriteLine(new string('-', 20));
        }

        public void AddSection(Section s)
        {
            sectionList.Add(s);
            countSection++;
        }

        public void RemoveSecton()
        {
            if (countSection != 0)
            {
                PutChooseMessage();
                var userChoose = CheckInput(countSection);
                if (userChoose != -1)
                {
                    sectionList[userChoose].CategoryAdd();
                }
            }
            else
            {
                Console.WriteLine("No items for removing!");
                return;
            }

            Console.WriteLine(new string('-', 20));
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
            Console.WriteLine(new string('-', 20));
            return i;
        }

        public void UpdateSection()
        {
            
            
        }


        //============= CATEGORY ============
        public void AddCategory()
        {
            PutChooseMessage();
            var userChoose = CheckInput(CountSection);

            if (userChoose != -1)
            {
             sectionList[userChoose].CategoryAdd();                
            }
        }

        public void ShowCategory()
        {
            PutChooseMessage();
            var userChoose = CheckInput(CountSection);

            if (userChoose != -1)
            {
                sectionList[userChoose].ShowCategoryList();
            }
        }

        public void RemoveCategory()
        {
            PutChooseMessage();
            var userChoose = CheckInput(CountSection);

            if (userChoose != -1)
            {
                var section = sectionList[userChoose];
                if(section.CountCategory == 0)
                {
                    Console.WriteLine("No category for removing!");
                    return;
                }
                section.ShowCategoryList();
                userChoose = CheckInput(section.CountCategory);
                if (userChoose != -1)
                {
                    section.CategoryRemove(userChoose);
                }
            }
        }

        public void AddBook()
        {

        }

        public void Remove(Section section) {
            sectionList.Remove(section);
            countSection++;
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
                        choose--;
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

        public void PutChooseMessage()
        {
                ShowSectionList();
                Console.Write("Choose number of section ->");
        }
    }

} 
