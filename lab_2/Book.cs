using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    class Book : Item
    {
        string author;
        
        short pages;
        public Book() { book_name = "Bookname"; }
        string book_name;
        public override void Show()
        {
            Console.WriteLine("{0}, {1}, {2}, {3}", itemName, price, author, pages);
        }
    }
}
