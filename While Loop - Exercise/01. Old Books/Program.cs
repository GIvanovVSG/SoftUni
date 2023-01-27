using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int bookId = 0;
            string searchBook;

            while((searchBook = Console.ReadLine()) != "No More Books")
            {
                bookId++;

                if(bookName == searchBook)
                {
                    Console.WriteLine($"You checked {bookId - 1} books and found it.");
                    break;
                }
            }

            if(searchBook == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {bookId} books.");
            }
        }
    }
}
