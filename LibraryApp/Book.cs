using System.Text.Json.Serialization;

public class Book : IBorrowable
{
    // Properties: the data a book holds
    public string Title { get; }
    public string Author { get; }
    public int Year { get; }
    [JsonInclude]
    public bool IsAvailable { get; private set; } = true;

    // Constructor: runs when you create a new book
    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    // Methods: things a book can do
    public void Borrow()
    {
        if(!IsAvailable)
        {
            throw new InvalidOperationException($"'{Title}' is already borrowed.");
        }
        IsAvailable = false;
    }

    public void Return()
    {
        IsAvailable = true;
    }

    public override string ToString()
    {
        string status = IsAvailable ? "available" : "borrowed";
        return $"{Title} by {Author} ({Year}) - {status}";
    }
}