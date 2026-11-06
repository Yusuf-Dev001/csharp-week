var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<BookStore>();

var app = builder.Build();

app.MapGet("/", () => "Welcome to the Library API!");

app.MapGet("/books", (BookStore store) => store.GetAll() );

app.MapGet("books/{id:int}", (int id, BookStore store) =>
{
    var book = store.GetById(id);
    return book is null ? Results.NotFound() : Results.Ok(book);
});

app.MapPost("/books", (Book book, BookStore store) =>
{
    store.Add(book);
    return Results.Created($"/books/{book.Id}", book);
});

app.MapDelete("/books/{id:int}", (int id, BookStore store) => 
        store.Remove(id) ? Results.NoContent() : Results.NotFound());

app.Run();
