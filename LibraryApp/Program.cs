using System.Text.Json;

// var dune = new Book("Dune", "Frank Herbert", 1965);
// var hobbit = new Book("The Hobbit", "J.R.R Tolkien", 1937);

// Console.WriteLine(dune);
// Console.WriteLine(hobbit);

// dune.Borrow();
// Console.WriteLine(dune);
// try
// {
//     dune.Borrow();
// }
// catch (InvalidOperationException ex)
// {
//     Console.WriteLine($"Oops: {ex.Message}");
// }

// var ana1 = new Member("Ana", "ana@example.com");
// var ana2 = new Member("Ana", "ana@example.com");

// Console.WriteLine(ana1);
// Console.WriteLine(ana1 == ana2);

// // Value types vs reference types demo.

// int a = 5; 
// int b = a;
// b = 10;
// Console.WriteLine(a);

// var book1 = new Book("Dune", "Frank Hervert", 1965);
// var book2 = book1;
// book2.Borrow();
// Console.WriteLine(book1.IsAvailable);


var catalog = new Catalog();
const string FilePath = "books.json"; // MINI-PROJECT : A LIBRARY THAT REMEMBERS

if(File.Exists(FilePath))
{
    string saved = await File.ReadAllTextAsync(FilePath);
    var savedBooks = JsonSerializer.Deserialize<List<Book>>(saved) ?? new List<Book> ();

    foreach (var book in savedBooks)
    {
        catalog.Add(book);
    }
}
else
{
    catalog.Add(new Book("Dune", "Frank Herbert", 1965));
    catalog.Add(new Book("The Hobbit", "J.R.R Tolkien", 1937));
    catalog.Add(new Book("1984", "George Orwell", 1949));
}


// var found = catalog.FindByTitle("Dune");
// Console.WriteLine(found);
// found?.Borrow();
// Console.WriteLine(found);

// foreach (var book in catalog.All())
// {
//     Console.WriteLine(book);
// }

// var books = catalog.All();

// var oldBooks = books.Where(b => b.Year < 1950);
// var byTitle = books.OrderBy(b => b.Title);
// var titles = books.Select(b => b.Title);

// foreach (var book in titles)
// {
//     Console.WriteLine(book);
// }

// int count = books.Count();
// bool hasOrWell = books.Any(b => b.Author == "George Orwell");

// Console.WriteLine($"Titles: {string.Join(", ", titles)}");
// Console.WriteLine($"{count} books. Any by Orwell? {hasOrWell}");

// foreach (var group in books.GroupBy(b => b.Author))
// {
//     Console.WriteLine($"{group.Key}: {group.Count()} book(s)");
// }

void PrintAll<T>(IEnumerable<T> items)
{
    if(!items.Any())
    {
        Console.Write("No item matched.");
        return;
    }
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}

// PrintAll(catalog.Available());
// PrintAll(new List<int> {1, 2, 3});


// MINI-PROJECT: LIBRARY MENU

while (true)
{
    Console.WriteLine();
    Console.WriteLine("=== My Library ===");
    Console.WriteLine("1) List all books");
    Console.WriteLine("2) Search by author");
    Console.WriteLine("3) Show available books");
    Console.WriteLine("4) Borrow a book");
    Console.WriteLine("5) Return a book");
    Console.WriteLine("6) Exit");
    Console.WriteLine();
    Console.Write("Choose an option: ");
    string? option = Console.ReadLine();
    

    switch (option)
    {
        case "1":
            PrintAll(catalog.All());
            break;
        case "2":
            Console.Write("Enter the name of author: ");
            string author = Console.ReadLine() ?? "";
            PrintAll(catalog.ByAuthor(author));
            break;
        case "3":
            PrintAll(catalog.Available());
            break;
        case "4":
            Book? bookToBorrow = GetBook();
            if(bookToBorrow is null)
            {
                Console.WriteLine("Book not found.");
                break;
            }
            try
            {
                bookToBorrow?.Borrow();
                Console.Write($"You successfully borrowed {bookToBorrow?.Title}");
                    
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;
        case "5":
            Book? bookToReturn = GetBook();
            if(bookToReturn is null)
            {
                Console.WriteLine("Book not found.");
                break;
            } 
            if (bookToReturn.IsAvailable)
            {
                Console.WriteLine("This book is not borrowed");
                break;
            } 
            bookToReturn.Return();
            Console.Write($"You successfully returned {bookToReturn.Title}");
            break;
        case "6":
            var options = new JsonSerializerOptions {WriteIndented = true };
            string json = JsonSerializer.Serialize(catalog.All(), options);
            await File.WriteAllTextAsync(FilePath, json);
            Console.WriteLine("Library saved. Goodbye!");
            return;
        default:
             Console.WriteLine("Please choose 1 to 6.");
             break;
    }

    Book? GetBook()
    {
         Console.Write("Enter the book title: ");
        string title = Console.ReadLine() ?? "";
        return catalog.FindByTitle(title);
    }
}


