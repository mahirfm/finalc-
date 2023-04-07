using System.Xml.Linq;

namespace final_C
{
    using System;
    using System.Collections.Generic;

    class BookStore
    {
        static List<Book> bookList = new List<Book>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Bookstore Console Application");
                Console.WriteLine("1. Add book to the inventory");
                Console.WriteLine("2. View all books in the inventory");
                Console.WriteLine("3. Search for a book");
                Console.WriteLine("4. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        ViewBooks();
                        break;
                    case 3:
                        SearchBooks();
                        break;
                    case 4:
                        Console.WriteLine("Exiting application...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option selected. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddBook()
        {
            Console.WriteLine("Enter book title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter author name: ");
            string author = Console.ReadLine();
            Console.WriteLine("Enter book price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Book book = new Book(title, author, price);
            bookList.Add(book);

            Console.WriteLine("Book added successfully.");
        }

        static void ViewBooks()
        {
            Console.WriteLine("List of Books:");
            foreach (Book book in bookList)
            {
                Console.WriteLine(book.ToString());
            }
        }

        static void SearchBooks()
        {
            Console.WriteLine("Enter book title or author name: ");
            string keyword = Console.ReadLine();

            List<Book> searchResults = new List<Book>();
            foreach (Book book in bookList)
            {
                if (book.Title.ToLower().Contains(keyword.ToLower()) || book.Author.ToLower().Contains(keyword.ToLower()))
                {
                    searchResults.Add(book);
                }
            }

            if (searchResults.Count > 0)
            {
                Console.WriteLine("Search results:");
                foreach (Book book in searchResults)
                {
                    Console.WriteLine(book.ToString());
                }
            }
            else
            {
                Console.WriteLine("No results found for your search.");
            }
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

        public Book(string title, string author, decimal price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, Price: {Price:C}";
        }
    }

}
