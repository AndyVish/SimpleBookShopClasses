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
            countBook++;
        }

        public int CountBook { get { return countBook; } }

        private void BookAdd()
        {
            Book book = new Book();
            book.Update();
            bookList.Add(book);
        }

        private void BookRemove(int index)
        {
            bookList.Remove(bookList[index]);
        }


        public void ShowBookList()
        {
            int i = 1;
            foreach (var item in bookList)
            {
                Console.WriteLine("{0}) {1}", i, item);
                i++;
            }
        }

    }
}
