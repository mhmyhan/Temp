// See https://aka.ms/new-console-template for more information

using BooksLinq;

Console.WriteLine("Book List LINQ\n");

static void DisplayBookList(List<Book> bookList)
{
    foreach (var book in bookList)
    {
        Console.WriteLine(book);
    }
}

// create book list and add items
var books = new List<Book>();

books.AddRange(new List<Book>
{
    new Book(1, "the Catcher in the Rye", "J.D. Salinger", 227,
        "Little, Brown and Company", 1951, "Fiction", true),
    new Book(4, "The Hobbit", "J.R.R. Tolkien", 310,
        "George Allen & Unwin", 1937, "Fantasy", true),
    new Book(5, "Tender Is the Night", "F. Scott Fitzgerald", 317,
        "Charles Scribner", 1934, "Fiction", true),
    new Book(6, "The Great Gatsby", "F. Scott Fitzgerald", 180,
        "Charles Scribner", 1925, "Fiction", true),
    new Book(7, "To Kill a Mockingbird", "Harper Lee", 336,
        "J.B. Lippincott & Co.", 1960, "Fiction", true),
    new Book(8, "The Alchemist", "Paulo Coelho", 208,
        "HarperTorch", 1988, "Adventure", true),
    new Book(9, "Brave New World", "Aldous Huxley", 268,
        "Chatto & Windus", 1932, "Dystopian", true),
    new Book(10, "Moby-Dick", "Herman Melville", 635,
        "Harper & Brothers", 1851, "Adventure", true),
    new Book(11, "Pride and Prejudice", "Jane Austen", 279,
        "T. Egerton, Whitehall", 1813, "Romance", true),
    new Book(12, "The Lord of the Rings", "J.R.R. Tolkien", 1178,
        "George Allen & Unwin", 1954, "Fantasy", true),
    new Book(13, "Becoming", "Michelle Obama", 448,
        "Crown", 2018, "Autobiography", false),
    new Book(14, "Sapiens: A Brief History of Humankind", "Yuval Harari", 443,
        "Harper", 2011, "Non-Fiction", false),
    new Book(15, "Educated", "Tara Westover", 334,
        "Random House", 2018, "Autobiography", false),
    new Book(17, "Thinking, Fast and Slow", "Daniel Kahneman", 499,
        "Farrar, Straus and Giroux", 2011, "Non-Fiction", false),
    new Book(18, "The Body Keeps the Score", "Bessel van der Kolk", 464,
        "Viking", 2014, "Non-Fiction", false),
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


Console.WriteLine("\nTolkien and Coelho Books");
// fuzzy search algorithm?
var tolkienAndCoelhoBooks = books
    .Where(b => b.Author is "J.R.R. Tolkien" or "Paulo Coelho")
    .ToList();

DisplayBookList(tolkienAndCoelhoBooks);

Console.WriteLine("\nBooks with 'IS' in the title");

var isBooks = books
    .Where(b=> b.Title.Contains("is",StringComparison.CurrentCultureIgnoreCase))
    .ToList();

DisplayBookList(isBooks);

Console.WriteLine("\nBooks with a page count between 450 and 1000 (inclusive)");

var mediumSizeBooks = books
    .Where(b => b.PageCount is >= 450 and <= 1000)
    .ToList();

DisplayBookList(mediumSizeBooks);

Console.WriteLine("\nBooks in the Autobiography and Romance Genre");

var genrefilterList = new List<string> { "Autobiography", "Romance" };

var GenreFilteredBooks = books
    .Where(b => genrefilterList.Contains(b.Genre))
    .ToList();