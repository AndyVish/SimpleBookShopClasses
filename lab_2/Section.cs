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

        private void Remove(int index)
        {
            categoryList.Remove(categoryList[index]);
        }
        // public override void Show() { Console.WriteLine(name); }
        //public override void Update()
        //{
        //    Console.WriteLine("Enter new name");
        //    string tmp_name = Console.ReadLine();
        //    if (tmp_name.Trim() != "")
        //    {
        //        name = tmp_name;
        //    }
        //}




        //public string Name { get { return name; } }

        public override string ToString()
        {
            //return base.ToString();
            return name;
        }
        //    string sectionName;
        //    public Section() { }
        //    //List<>
        //    public Section(string name, int id, string sectName) : base(name, id)
        //    {
        //        sectionName = sectName;
        //    }

        //    string GetSection()
        //    {
        //        return sectionName;
        //    }

        //    public void Show()
        //    {
        //        Console.WriteLine("id = {0}, name = {1}, count = {2}, secName = {3}", Id, Name, Count, GetSection());
        //    }
        //    public void Update()
        //    {
        //        Console.WriteLine("Update");
        //    }
    }
}

