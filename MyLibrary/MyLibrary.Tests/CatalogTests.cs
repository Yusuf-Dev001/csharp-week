
using MyLibrary.Core;

namespace MyLibrary.Tests;

public class CatalogTests
{
    [Fact]
    public void ByAuthor_FindsMatchingBooks_IgnoringCase()
    {
        var catalog = new Catalog();
        catalog.Add(new Book("The Hobbit", "J.R.R. Tolkien", 1937));
        catalog.Add(new Book("Dune", "Frank Herbert", 1965));

        var results = catalog.ByAuthor("tolkien").ToList();

        Assert.Single(results); //  checks whether a collection contains exactly one element. can also return the element
        Assert.Equal("The Hobbit", results[0].Title);

    }

    [Fact]
    public void FindByTitle_ReturnNull_IfBookDoesNotExist()
    {
         var catalog = new Catalog();
        catalog.Add(new Book("The Hobbit", "J.R.R. Tolkien", 1937));
        catalog.Add(new Book("Dune", "Frank Herbert", 1965));

        var result = catalog.FindByTitle("The book");

        Assert.Null(result);
    }

    [Fact]
    public void Available_DoesNotInclude_BorrowedBooks()
    {
        var book1 = new Book("The Hobbit", "J.R.R. Tolkien", 1937);
        var book2 = new Book("Dune", "Frank Herbert", 1965);

        var catalog = new Catalog();
        catalog.Add(book1);
        catalog.Add(book2);

       book1.Borrow();

       var result = catalog.Available();

       Assert.Single(result);
       Assert.False(book1.IsAvailable);
       Assert.True(book2.IsAvailable);
    }
}