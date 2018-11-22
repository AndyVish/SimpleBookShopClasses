using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    enum Actions {Add, Remove, Update, Show }; 

    class Shop : CommonShopObject
    {
        int countSection;
        List<Section> sectionList;
        
        public Shop()
        {
            ///!!!!  countSection = 0; - origenal
            countSection = 2;
            sectionList = new List<Section>();

            sectionList.Add(new Section("Информационные технологии"));
            sectionList.Add(new Section("Ин-яз"));
                       
            Category k1 = new Category("Англ.");
            Category k2 = new Category("Фрфнц.");
            Category k3 = new Category("Итал.");
            sectionList[1].Add(k1);
            sectionList[1].Add(k2);
            sectionList[1].Add(k3);

            Category k4 = new Category("С++");
            Category k5 = new Category("Сsharp.");
            sectionList[0].CategoryAdd(k4);
            sectionList[0].CategoryAdd(k5);
        }

        public int CountSection{ get { return countSection; } }
        public void Add(Section s)
        {
            sectionList.Add(s);
            countSection++;
        }

        bool GetIndexCategory(out int index, Section sect)
        {
            index = -1;                
            if (sect.CountCategory-1 != 0)
            {
                sect.Show();
                index = CheckInput(sect.CountCategory);
                if (index != -1)
                {
                    return true;
                }                
            }
            Console.WriteLine("No category for removing!");
            return false;
        }

        public Category GetCategory()
        {
            if (GetIndexSection(out int index))
            {
                var e = sectionList[index];
                if (GetIndexCategory(out int idCt, e))
                {
                    return e.GetCategory(idCt);
                }
            }

            return null;
        }

        //============= BOOK ============
        public void AddBook()
        {

        }

        public void PutChooseMessage()
        {
                Show();
                Console.Write("Choose number of section ->");
        }

        //***************************
        
        public override void Remove()
        {
            if (GetIndexSection(out int index))
            {
                sectionList.Remove(sectionList[index]);
                countSection--;
            }
            Console.WriteLine(new string('-', 20));
        }

        public override void Add()
        {
            var section = new Section();
            section.Update();
            sectionList.Add(section);
            countSection++;
            Console.WriteLine(new string('-', 20));
        }


        public Section GetSection()
        {
            if(GetIndexSection(out int index))
            {
                return sectionList[index];
            }

            return null;
        }

        public override void Show()
        {
            int i = 0; 
            foreach (var item in sectionList)
            {
                i++;
                Console.WriteLine($"\t{i}) {item.Name}");                
            }
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
        //***************************
    }

} 
