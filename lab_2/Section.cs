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
        
        public int CountCategory { get { return countCategory; } }
        private void CategoryAdd()
        {
            Category category = new Category();
            category.Update();
            categoryList.Add(category);
            countCategory++;
        }

        private void CategoryRemove(int index)
        {
            categoryList.Remove(categoryList[index]);
            countCategory--;
        }

        public void ShowCategoryList()
        {
            int i = 1;
            foreach (var item in categoryList)
            {
                Console.WriteLine("{0}) {1}", i, item);
                i++;
            }
        }

    }
}

