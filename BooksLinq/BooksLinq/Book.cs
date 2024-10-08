﻿namespace BooksLinq;

public class Book
{
    private int Id { get; set; }
    public String Title { get; set; }
    public String Author { get; set; }
    public int PageCount { get; set; }
    private String Publisher { get; set; }
    public int PublishedYear { get; set; }
    public String Genre { get; set; }
    private Boolean IsClassic { get; set; }

    // Default Constructor
    public Book()
    {
        Id = 0;
        Title = "Unknown";
        Author = "Unknown";
        PageCount = 0;
        Publisher = "Unknown";
        PublishedYear = 0;
        Genre = "Unknown";
        IsClassic = false;
    }

    // Constructor that Initialises all Properties
    public Book(int id, string title, string author, int pageCount, string publisher, int publishedYear, string genre, bool isClassic)
    {
        Id = id;
        Title = title;
        Author = author;
        PageCount = pageCount;
        Publisher = publisher;
        PublishedYear = publishedYear;
        Genre = genre;
        IsClassic = isClassic;
    }
    
    // Methods
    
    
    public override string ToString()
    {
        return $"{Id}: {Author} ({PublishedYear}). {Title}." +
               $"\n   Pages: {PageCount}, Publisher: {Publisher}, Genre: {Genre}, Classic: {IsClassic}";
    }
    
}