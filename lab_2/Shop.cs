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
        int countCategory;
        List<Section> sectionList;
        
        public Shop()
        {
            countSection = 0;
            countCategory = 0;
            sectionList = new List<Section>();
        }

        public int CountShop { get { return countSection; } }
        public int CountCategory { get { return countCategory; } }

        public void Add(Object obj)
        {
            if (obj is Section)
            {
                Section tmp = (Section)obj;
                sectionList.Add(tmp);
                countSection++;
            }
            else if (obj is Category)
            {
                Category tmp = (Category)obj;
                countCategory++;
            }
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
