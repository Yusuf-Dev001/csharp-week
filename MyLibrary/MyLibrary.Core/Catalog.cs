namespace MyLibrary.Core;
public class Catalog
{
        private List<Book> books = new List<Book>();

    public void Add(Book book)
    {
        books.Add(book);
    }

    public IEnumerable<Book> All()
    {
        return books;
    }

    public Book? FindByTitle(string title) => 
        books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        
    public IEnumerable<Book> ByAuthor(string author) => 
        books.Where(b => b.Author.Contains(author, StringComparison.OrdinalIgnoreCase));

    public IEnumerable<Book> Available() =>
        books.Where(b => b.IsAvailable);

    
}