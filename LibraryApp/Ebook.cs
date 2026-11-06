public class Ebook : Book
{
    public double FileSizeMb { get; }
    public Ebook(string title, string author, int year, double fileSizeMb) : base(title, author, year)
    {
        FileSizeMb = fileSizeMb;
    }
    
}