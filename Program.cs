// Program.cs
using System;

class Program
{
    static void Main()
    {
        Book[] books = new Book[3];

        // Initialize books
        books[0] = new Book("The Catcher in the Rye", "J.D. Salinger", 1951);
        books[1] = new Book("To Kill a Mockingbird", "Harper Lee", 1960);
        books[2] = new Book("1984", "George Orwell", 1949);

        // Display book information
        foreach (var book in books)
        {
            Console.WriteLine("Book Information:");
            book.DisplayInfo();
            Console.WriteLine();
        }
    }
}
