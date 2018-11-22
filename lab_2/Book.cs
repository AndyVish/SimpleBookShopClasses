using System;


namespace lab_2
{
    class Book : Item
    {
        string author;
        short pages;
        public Book()
        {
            Console.Write("name ->");
            itemName = Console.ReadLine();

            Console.Write("author ->");
            author = Console.ReadLine();

            Console.Write("price ->");
            double.TryParse(Console.ReadLine(), out price);

            Console.Write("pages ->");
            short.TryParse(Console.ReadLine(), out pages);
        }
        public override void Show()
        {
            Console.WriteLine("{0}, {1}, {2}, {3}", itemName, price, author, pages);
        }
    }
}
