using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    class Category
    {
        string nameCategory;
        int countBook;
        List<Book> bookList;

        public Category()
        {
            nameCategory = "sec_";
            bookList = new List<Book>();
            countBook++;
        }

        
    }
}
