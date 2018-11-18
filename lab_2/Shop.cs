﻿using System;
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

        public void Add(Section section)
        {
            sectionList.Add(section);
            countSection++;
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
                Console.WriteLine("{0}) {1}", i, item);
            }
        }

               
    }

} 
