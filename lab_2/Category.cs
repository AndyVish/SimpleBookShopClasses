using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    class Category : CommonShopObject
    {
        int countBook;
        List<Book> bookList;

        public Category()
        {
            name = "sec_"+id;
            id++;
            bookList = new List<Book>();
        }

        public Category(string name)
        {
            this.name = name;
            id++;
            bookList = new List<Book>();
        }

        public int CountBook { get { return countBook; } }
                        
        public override void Show()
        {
            int i = 0;
            foreach (var item in bookList)
            {
                i++;
                Console.Write("{0}) ", i);
                item.Show();                
            }
        }

        public override void Remove()
        {
            Show();
            int select = CheckInput(countBook);
            if (select != -1)
            {
                bookList.Remove(bookList[select]);
                countBook--;
            }
        }
        
        public override void Add()
        {
            var book = new Book();
           //section.Update();
            bookList.Add(book);
            countBook++;
            Console.WriteLine(new string('-', 20));
        }
               
    }
}
