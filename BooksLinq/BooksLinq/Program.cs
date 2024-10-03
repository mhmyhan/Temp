﻿// See https://aka.ms/new-console-template for more information

using BooksLinq;

Console.WriteLine("Book List LINQ\n");

var books = new List<Book>
{
    new Book(1, "the Catcher in the Rye", "J.D. Salinger", 227,
        "Little, Brown and Company", 1951, "Fiction", true),
};

static void DisplayBookList(List<Book> bookList)
{
    foreach (var book in bookList)
    {
        Console.WriteLine(book);
    }
    
}

DisplayBookList(books);

books.AddRange(new List<Book>
{
    new Book(19, "1984", "George Orwell", 328,
        "Secker & Warburg", 1949, "Dystopian", true),
    new Book(20, "Crime and Punishment", "Fyodor Dostoevsky", 671,
        "The Russian Messenger", 1866, "Philosophical Fiction", true),
    new Book(21, "The Catcher in the Rye", "J.D. Salinger", 277,
        "Little, Brown and Company", 1951, "Fiction", true),
    new Book(22, "One Hundred Years of Solitude", "Gabriel García Márquez", 417,
        "Harper & Row", 1967, "Magical Realism", true),
    new Book(23, "The Odyssey", "Homer", 541,
        "Ancient Greece", -800, "Epic", true),
    new Book(24, "War and Peace", "Leo Tolstoy", 1225,
        "The Russian Messenger", 1869, "Historical Fiction", true),
    new Book(25, "The Divine Comedy", "Dante Alighieri", 798,
        "John Murray", 1320, "Epic Poetry", true),
    new Book(26, "Frankenstein", "Mary Shelley", 280,
        "Lackington, Hughes, Harding, Mavor & Jones", 1818, "Gothic Fiction", true),
    new Book(27, "The Picture of Dorian Gray", "Oscar Wilde", 254,
        "Ward, Lock & Co.", 1890, "Philosophical Fiction", true),
    new Book(28, "The Brothers Karamazov", "Fyodor Dostoevsky", 824,
        "The Russian Messenger", 1880, "Philosophical Fiction", true),
    new Book(29, "Don Quixote", "Miguel de Cervantes", 1072,
        "Francisco de Robles", 1605, "Satire", true),
    new Book(30, "Wuthering Heights", "Emily Brontë", 416,
        "Thomas Cautley Newby", 1847, "Gothic Fiction", true),
    new Book(31, "Meditations", "Marcus Aurelius", 254,
        "Ancient Rome", 180, "Philosophy", true),
    new Book(32, "The Art of War", "Sun Tzu", 273,
        "Ancient China", -500, "Philosophy", true),
    new Book(33, "The Kite Runner", "Khaled Hosseini", 372,
        "Riverhead Books", 2003, "Historical Fiction", true),
    new Book(34, "Catch-22", "Joseph Heller", 453,
        "Simon & Schuster", 1961, "Satire", true),
    new Book(35, "The Road", "Cormac McCarthy", 287,
        "Alfred A. Knopf", 2006, "Post-Apocalyptic Fiction", true),
    new Book(36, "The Hitchhiker's Guide to the Galaxy", "Douglas Adams", 224,
        "Pan Books", 1979, "Science Fiction", true),
    new Book(37, "Anna Karenina", "Leo Tolstoy", 864,
        "The Russian Messenger", 1877, "Literary Fiction", true),
    new Book(38, "A Tale of Two Cities", "Charles Dickens", 489,
        "Chapman & Hall", 1859, "Historical Fiction", true)
});


Console.WriteLine("\nTolkien Books");
// fuzzy search algorithm?
var tolkienBooks = books
    .Where(b => b.Author == "J.R.R. Tolkien")
    .ToList();

DisplayBookList(tolkienBooks);

