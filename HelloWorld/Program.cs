// DISPLAYING OUTPUT TO THE CONSOLE
// Console.WriteLine("Printing to the console");
// Console.WriteLine("Don't forget to end with a semi-colon");
// Console.WriteLine("This one will not add a line break at the end");
// Console.WriteLine("Hello World");
// Console.Write("Writes without adding a new line");
// Console.WriteLine();

// ACCEPT USER INPUT
// string? value = Console.ReadLine();
// Console.WriteLine("You entered " + value);

// Console.Write("Enter a value so I can display it on the console ");  //prompting user
// string? answer = Console.ReadLine();
// Console.WriteLine("You entered " + answer + " when I prompted");
// Note: Console.ReadLine always returns a text even when a number is entered.

// Manipulate Strings
// string first = "Hello";
// string last = "World";
// string message = first + ", " + last + "!";         // concatenation
// Console.WriteLine(message);

// string name = "Yusuf";
// Console.WriteLine($"Hello, {name}!");        // String interpolation, cleaner than concatenation

// Console.Write("Enter a word with space to manipulate it ");
// string? word = Console.ReadLine();
// string wordInUpper = word.ToUpper();
// string wordInLower = word.ToLower();
// int length = word.Length;
// string wordWithoutSpace = word.Replace(" ", "");
// Console.WriteLine($"Upper: {wordInUpper} \nLower: {wordInLower} \nLength: {length} \nWithoutSpace: {wordWithoutSpace}");

// EXERCISE (CREATE A PERSONALIZED GREETING)
 // Display a welcome message

 // Ask for the user's name

 // Display a personalized greeting


 // C# DATATYPES
 // STRING, CHAR, INT, DECIMAL,DOUBLE, BOOL

 // MATH OPERATORS
// int x = 34;
// Console.WriteLine(x + 1);
// Console.WriteLine(x - 1);
// Console.WriteLine(x * 1);
// Console.WriteLine(x / 3); // This does integer division
// Console.WriteLine(x % 3);

 // Collect the bill amount and tip percentage
// Console.Write("Enter the bill amount ");
// int amount = int.Parse(Console.ReadLine());
// Console.Write("Enter the tip percentage ");
// decimal percentage = Convert.ToDecimal(Console.ReadLine());

 // Display the entered values
// Console.WriteLine($"Amount: {amount+1} \nPercentage: {percentage+1} ");
 // Calculate the tip and total

 // Display the results

// decimal number = 48.6858m;
// Console.WriteLine($"The number to 1dp is {Math.Round(number)}");
// Console.WriteLine("Windows "+ 7 + 4);
// Console.WriteLine($"Windows {1 + 1}");
// Console.WriteLine("Windows "+ 1 + 1);

// string name = "Sam";
// int age = 25;
// decimal price = 88.5547m;
// bool isLearning = true;

// Console.WriteLine($"Hi {name}! You are {age}");
// Console.WriteLine($"A coffee costs {price:C}.");
// Console.Write($"Learning C#? {isLearning}");

// Console.Write("What's your name? ");
// string? name = Console.ReadLine();
// Console.WriteLine($"Nice to meet you, {name}!");

// Console.Write("How old are you? ");
// int age = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine($"Next year, you'll be {age + 1}.");

