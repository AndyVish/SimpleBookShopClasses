using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    class Section : CommonShopObject
    {
        int countCategory;
        List<Category> categoryList;
        public Section()
        {
            name = "sec_"+id;
            categoryList = new List<Category>();
            
        }

        public Section(string name)
        {
            this.name = name;
            categoryList = new List<Category>();
          
        }

        public int CountCategory { get { return countCategory; } }

        public override void Add()
        {
            Category category = new Category();
            category.Update();
            categoryList.Add(category);
            countCategory++;
        }

        public Category GetCategory(int index)
        {
            return categoryList[index];
        }
        
        public void Add(Category k)
        {
            categoryList.Add(k);
            countCategory++;
        }


        public void Remove(int index)
        {
            categoryList.Remove(categoryList[index]);
            countCategory--;
        }

        public void CategoryUpdate(int index)
        {
            categoryList[index].Update();
        }
        
        //***************************
        public override void Remove()
        {
            Show();
            int select = CheckInput(countCategory);
            if (select != -1)
            {
                categoryList.Remove(categoryList[select]);
                countCategory--;
            }            
        }

        public override void Show()
        {
            int i = 0;
            foreach (var item in categoryList)
            {
                i++;
                Console.WriteLine("\t{0}) {1}", i, item.Name);
            }
        }
        //***************************

    }
}

