using System.Net.Http.Json;
using Spectre.Console;

using var client = new HttpClient();

var todo = await client.GetFromJsonAsync<Todo>("https://jsonplaceholder.typicode.com/todos/1");

Console.WriteLine($"Todo #{todo?.Id}: {todo?.Title}");
Console.WriteLine($"Completed: {todo?.Completed}");

AnsiConsole.MarkupLine("[bold green]Hello[/] from [yellow]Spectre.Console[/]!");

public record Todo(int userId, int Id, string Title, bool Completed);
