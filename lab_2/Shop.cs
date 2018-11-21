using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    enum Actions {Add, Remove, Update, Show }; 

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


        bool GetIndexSection(out int index)
        {
            index = -1;
            if (countSection != 0)
            {
                PutChooseMessage();
                index = CheckInput(countSection);
                if (index != -1)
                {
                    return true;
                }
            }
            else
            {
                Console.WriteLine("No items!");
            }
            return false;
        }

        public void RemoveSecton()
        {
            if (GetIndexSection(out int index))
            {
                sectionList.Remove(sectionList[index]);
                countSection--;
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
            return i;
        }

        public void UpdateSection()
        {
            if (GetIndexSection(out int index))
            {
                sectionList[index].Update();
                countSection--;
            }
            Console.WriteLine(new string('-', 20));
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

        bool GetIndexCategory(out int index, Section sect)
        {
            index = -1;                
            if (sect.CountCategory-1 != 0)
            {
                sect.ShowCategoryList();
                index = CheckInput(sect.CountCategory);
                if (index != -1)
                {
                    return true;
                }                
            }
            Console.WriteLine("No category for removing!");
            return false;
        }

        public void RemoveCategory()
        {
            if (GetIndexSection(out int tmpId))
            {
                var section = sectionList[tmpId];
                if (GetIndexCategory(out int index, section))
                {
                    section.CategoryRemove(index);
                }
            }
        }


        //============= BOOK ============
        public void AddBook()
        {

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
