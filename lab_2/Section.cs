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
            countCategory++;
        }

        public Section(string name)
        {
            this.name = name;
            categoryList = new List<Category>();
            countCategory++;
        }
        public int CountCategory { get { return countCategory; } }

        public void CategoryAdd()
        {
            Category category = new Category();
            category.Update();
            categoryList.Add(category);
            countCategory++;
        }

        public void CategoryAdd(Category k)
        {
            
            categoryList.Add(k);
            countCategory++;
        }
        public void CategoryRemove(int index)
        {
            categoryList.Remove(categoryList[index]);
            countCategory--;
        }

        
        public void ShowCategoryList()
        {
            int i = 0;
            foreach (var item in categoryList)
            {
                i++;
                Console.Write("{0})", i);
                    item.Show();        
            }
        }

    }
}

