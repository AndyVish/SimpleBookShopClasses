using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    class Section : CommonShopObject
    {
        string nameSection;
        int countCategory;
        List<Category> categoryList;
        public Section()
        {
            nameSection = "sec_";
            categoryList = new List<Category>();
            countCategory++;
        }
        
        public int CountCategory { get { return countCategory; } }
        private void CategoryAdd()
        {
            Category category = new Category();
            category.Update();
            categoryList.Add(category);
        }

        private void CategoryRemove(int index)
        {
            categoryList.Remove(categoryList[index]);
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

        public void Update()
        {
            Console.WriteLine("Enter name");
            string tmp_name = Console.ReadLine();
            if (tmp_name.Trim() != "")
            {
                nameSection = tmp_name;
            }
        }

  
    }
}

