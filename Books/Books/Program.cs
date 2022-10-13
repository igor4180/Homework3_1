using System;
//выводит пустой экран

namespace Library
{
    class Program
    {
        private static List<Book> books;

        static void Main(string[] args)
        {
            InitializeBookList();
            FindByPublisher();


            Console.ReadKey();
        }

        private static void FindByPublisher()
        {
            throw new NotImplementedException();
        }

        private static void FindByPublisher(string publisher)
        {
            books.FindAll(book => book.Publisher == publisher).
                  ForEach(book => Console.WriteLine(book.ID));
        }

        private static void InitializeBookList()
        {
            books = new List<Book>();
            books.AddRange(new[]
            {
             new Book(0, "Автор 1", "Книга 1", "Издательство 1", 150, DateTime.Today),
             new Book(1, "Автор 1", "Книга 2", "Издательство 2", 1150, DateTime.Today),
             new Book(2, "Автор 2", "Книга 1", "Издательство 2", 150, DateTime.Today),
             new Book(3, "Автор 3", "Книга 1", "Издательство 3", 150, DateTime.Today)
            });
        }
        class Book
        {
            public int ID { get; set; }
            public string Author { get; set; }
            public string Name { get; set; }
            public string Publisher { get; set; }
            public DateTime PublicationYear { get; set; }
            public int PageNumber { get; set; }

            public Book
                (int id,
                string author,
                string name,
                string publisher,
                int pageNumber,
                DateTime year)
            {
                this.ID = id;
                this.Author = author;
                this.Name = name;
                this.Publisher = publisher;
                this.PageNumber = pageNumber;
                this.PublicationYear = year;
            }
        }
    }
}
