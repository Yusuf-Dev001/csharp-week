using System.Text.Json;
using System.Text.Json.Serialization;


// SERIALIZATION DEMO
// public class Employee
// {
//     public string Name { get; set; }
//     public int Age { get; set; }
//     public string Address { get; set; }

// }

// class Program
// {
//     static void Main()
//     {
//         var customer = new Employee
//         {
//             Name = "Anette Thompson",
//             Age = 30,
//             Address = "123 Main St"
//         };

//         string jsonString = JsonSerializer.Serialize(customer);
//         Console.WriteLine(jsonString);
//     }
// }


// DESERIALIZATION DEMO
// public class Employee
// {
//     public string Name { get; set; } = "Anette Thomsen";
//     public int Age { get; set; } 
//     public string Address { get; set; } = "123 Main St";
// }

// class Program
// {
//     static void Main()
//     {
//         string jsonString1 = "{\"Name\":\"Anette Thomsen\",\"Age\":30,\"Address\":\"123 Main St\"}";
//         string jsonString2 = @"{""Nmae"": ""Anette Thomsen"", ""Age"": 30, ""Address"": ""123 Main St""}";
//         var customer = JsonSerializer.Deserialize<Employee>(jsonString1);
//         if (customer != null)
//         {
//             Console.WriteLine($"Name: {customer.Name}, Age: {customer.Age}, Address: {customer.Address}");
//         }
//         else
//         {
//             Console.WriteLine("Deserialization failed");
//         }
//     }
// }


                    // Customize serialization behavior

// public class WeatherForecastWithIgnoreAttribute
// {
//     public DateTimeOffset Date { get; set; }
//     public int TemperatureCelcius { get; set; }
//     [JsonIgnore]  // Ignores individual property during serialization
//     public string? Summary { get; set; }
// }


class Program
{
    static void Main()
    {
        // var forecast = new WeatherForecastWithIgnoreAttribute
        // {
        //     Date = DateTimeOffset.Now,
        //     TemperatureCelcius = 25,
        //     Summary = "Warm"
        // };

        

         var forecast = new WeatherForecastWithROProperty
        {
            Date = DateTimeOffset.Now,
            TemperatureCelsius = 25,
            Summary = "Warm"
        };

        var options = new JsonSerializerOptions
        {
            IgnoreReadOnlyProperties = true,
            WriteIndented = true
        };

        string jsonString =JsonSerializer.Serialize(forecast, options);
        Console.WriteLine(jsonString);
    }
}

