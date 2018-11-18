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

        public void Update()
        {
            Console.WriteLine("Enter name");
            string tmp_name = Console.ReadLine();
            if (tmp_name.Trim() != "")
            {
                nameCategory = tmp_name;
            }
        }

    }
}
