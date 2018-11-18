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

        public void Add(Object obj)
        {
           
        }

        public void Remove(Object obj) {

        }

        public void ShowSectionList()
        {
            
        }

        public void ShowCategoryList()
        {

        }
               
    }

} 
