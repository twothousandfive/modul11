using System;
using System.Collections.Generic;
using HOMEWORK;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public string Status { get; set; }

    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        Status = "available";
    }

    public bool Rent()
    {
        if (Status == "available")
        {
            Status = "rented";
            return true;
        }
        return false;
    }

    public bool ReturnBook()
    {
        if (Status == "rented")
        {
            Status = "available";
            return true;
        }
        return false;
    }
}

public class Reader
{
    public string Name { get; set; }
    public List<Book> RentedBooks { get; set; }

    public Reader(string name)
    {
        Name = name;
        RentedBooks = new List<Book>();
    }

    public bool RentBook(Book book)
    {
        if (book.Rent())
        {
            RentedBooks.Add(book);
            return true;
        }
        return false;
    }

    public bool ReturnBook(Book book)
    {
        if (RentedBooks.Contains(book) && book.ReturnBook())
        {
            RentedBooks.Remove(book);
            return true;
        }
        return false;
    }
}

public class Librarian
{
    public string Name { get; set; }

    public Librarian(string name)
    {
        Name = name;
    }

    public void ManageBooks(Library library, Book book, string action)
    {
        if (action == "add")
        {
            library.AddBook(book);
        }
        else if (action == "remove")
        {
            library.RemoveBook(book);
        }
    }
}

public class Library
{
    public List<Book> Books { get; set; }

    public Library()
    {
        Books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        Books.Remove(book);
    }

    public void ListBooks()
    {
        foreach (Book book in Books)
        {
            string status = book.Status == "available" ? "В наличии" : "Арендована";
            Console.WriteLine($"Название: {book.Title}, Автор: {book.Author}, ISBN: {book.ISBN}, Статус: {status}");
        }
    }
}

public class Program
{
    public static void Main()
    {
        /*Library library = new Library();
        Librarian librarian = new Librarian("John");
        Reader reader = new Reader("Alice");

        Book book1 = new Book("1984", "George Orwell", "123456789");
        Book book2 = new Book("Brave New World", "Aldous Huxley", "987654321");

        librarian.ManageBooks(library, book1, "add");
        librarian.ManageBooks(library, book2, "add");

        library.ListBooks();

        reader.RentBook(book1);
        library.ListBooks();

        reader.ReturnBook(book1);
        library.ListBooks();*/
        
        
        Console.WriteLine("Welcome to Hotel Booking System!");

        // Инициализация сервисов
        IHotelService hotelService = new HotelService();
        IBookingService bookingService = new BookingService();
        IUserManagementService userService = new UserManagementService();
        
        // Логика для взаимодействия с пользователем через консоль
        var hotels = hotelService.SearchHotels("New York", "Deluxe", 200);
        foreach (var hotel in hotels)
        {
            Console.WriteLine($"{hotel.Name} - {hotel.Location}");
        }

        Console.WriteLine("Enter hotel id to book a room:");
        var hotelId = int.Parse(Console.ReadLine());

        var bookingSuccess = bookingService.BookRoom(hotelId, 1, "Deluxe", DateTime.Now, DateTime.Now.AddDays(3));
        if (bookingSuccess)
        {
            Console.WriteLine("Room booked successfully!");
        }
        else
        {
            Console.WriteLine("Failed to book the room.");
        }
    }
}
