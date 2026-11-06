using MyLibrary.Core;
namespace MyLibrary.Tests;

public class BookTests
{
    [Fact]
    public void NewBook_IsAvailable()
    {
        // Arrange: set things up
        Book book = new Book("Dune", "Frank Herbert", 1965);

        //Assert: check the result
        Assert.True(book.IsAvailable);
    }

    [Fact]
    public void Borrow_MakesBookUnavailable()
    {
        // Arrange
        Book book = new Book("Dune", "Frank Herbert", 1956);

        // Act: do the thing you are testing
        book.Borrow();

        // Assert
        Assert.False(book.IsAvailable);
    }

    [Fact]
    public void Borrow_WhenAlreadyBorrowed_Throws()
    {
        var book = new Book("Dune", "Frank Herbert", 1956);
        book.Borrow();
        Assert.Throws<InvalidOperationException>(() => book.Borrow());
        
    }
}
