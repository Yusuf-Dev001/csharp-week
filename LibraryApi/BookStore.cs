public class BookStore
{
    private readonly List<Book> _books = new()
    {
        new Book(1, "Dune", "Frank Herbert", 1956),
        new Book(2, "The Hobbit", "J.R.R Tolkien", 1937)
    };

    public IEnumerable<Book> GetAll() => _books;

    public Book? GetById(int id) => _books.FirstOrDefault(b => b.Id == id);

    public void Add(Book book) => _books.Add(book);

    public bool Remove(int id) => _books.RemoveAll(b => b.Id == id) > 0;
}