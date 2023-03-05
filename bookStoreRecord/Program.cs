using System;

namespace recordscratch
{
    public record Bookstore(int ID, string Title, string Author, double Price);

    class Program
    {
        static void Main(string[] args)
        {
            Bookstore bookstore1 = new Bookstore(1, "title1", "author1", 1.50);
            Bookstore bookstore2 = new Bookstore(2, "title2", "author2", 2.50);
            Bookstore bookstore3 = new Bookstore(3, "title3", "author3", 3.50);
            Console.WriteLine(bookstore1);
            Console.WriteLine("///");
            Console.WriteLine(bookstore2);
            Console.WriteLine("///");
            Console.WriteLine(bookstore3);
        }
    }
}