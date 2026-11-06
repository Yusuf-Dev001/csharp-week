// MAKING DECISIONS AND REPEATING THINGS

// bool isGameOver = true;
// bool isWinner = false;

// int total = 17;

// if (total >= 15)
// {
//     Console.WriteLine("You Win");
// }

// int total = 12;

// if (total <= 15)
// {
//     Console.WriteLine("You win!");
// }
// else
// {
//     Console.WriteLine("Sorry, you lose.");
// }

// int total = 12;

// if (total >= 16)
// {
//     Console.WriteLine("You win a new car!");
// }
// else if (total >= 10)
// {
//     Console.WriteLine("You win a new laptop");
// }
// else if (total == 7)
// {
//     Console.WriteLine("You win a trip for two");
// }
// else
// {
//     Console.WriteLine("You win a kitten");
// }  // NOTE: Order your conditions from most specific to least specific 

// bool hasTicket = true;
// int age = 16;

// if (hasTicket)
// {
//     if (age >= 18)
//     {
//         Console.WriteLine("Entry granted.");
//     }
//     else
//     {
//         Console.WriteLine("Minors must be accompanied by an adult.");
//     }
// }

// int age = 20;
// bool hasTicket = true;

// if (age >= 18 && hasTicket)
// {
//     Console.WriteLine("Entry granted.");
// }
// else
// {
//     Console.WriteLine("Entry denied.");
// }

// bool isWeekend = false;
// bool isHoliday = true;

// if (isWeekend || isHoliday)
// {
//     Console.WriteLine("The office is closed.");
// }

// bool isLoggedIn = false;

// if (!isLoggedIn)
// {
//     Console.WriteLine("Please log in to continue");
// }

// int roll1 = 6, roll2 = 6, roll3 = 5;

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 

// Console.WriteLine("You rolled doubles");

// int employeeLevel = 200;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel)
// {
//     case 100: 
//         title = "Junior Associate";
//         break;
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default: 
//         title = "Associate";
//         break;
// }

// switch (employeeLevel)
// {
//     case 100:
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }

// title = employeeLevel switch
// {
//     100 => "Junior Associate",
//     200 => "Senior Associate",
//     300 => "Manager",
//     400 => "Senior Manager",
//     _ => "Associate",
// };


// Console.WriteLine($"{employeeName}, {title}");

// CHALLENGE
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// switch (product[0])
// {
//     case "01":
//         type = "Sweat shirt";
//         break;
//     case "02":
//         type = "T-shirt";
//         break;
//     case "03":
//         type = "Sweat pants";
//         break;
//     default: 
//         type = "Other";
//         break;
// }

// switch (product[1])
// {
//     case "BL":
//         color = "Black";
//         break;
//     case "MN":
//         color = "Maron";
//         break;
//     default: 
//         color = "White";
//         break;
// }

// switch (product[2])
// {
//     case "S":
//         size = "Small";
//         break;
//     case "M":
//         size = "Medium";
//         break;
//     case "L":
//         size = "Large";
//         break;
//     default:
//         size = "One Size Fits All";
//         break;
// }

// Console.WriteLine($"Product: {size} {color} {type}");

// int health = 3;

// while (health > 0)
// {
//     Console.WriteLine($"Player is alive. Health: {health}");
//     health--;
// }

// int attempts = 0;

// do
// {
//     attempts++;
//     Console.WriteLine($"Attempt number {attempts}");
// }
// while(attempts < 3);

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }

// for (int i = 10; i >= 0; i--)
// {
//     Console.WriteLine(i);
// }

// for (int i = 0; i < 10; i += 3)
// {
//     Console.WriteLine(i);
// }

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if(i == 7) break;
// }

// string[] names = {"Alex", "Eddie", "David", "Michael"};
// for (int i = names.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }

// foreach (var name in names)
// {
// cannot update a value in the array during foreach iteration
//     if (name == "David") name = "Sammy";   
// }

// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = 0; i < names.Length; i++)
// {
//     // can update a value in the array during for iteration
//     if (names[i] == "David") names[i] = "Sammy";
//     Console.WriteLine(names[i]);
// }


// CHALLENGE
// for (int i = 1; i <= 100; i++)
// {
//     if ( (i % 3 == 0) && (i % 5 == 0))
//     {
//         Console.WriteLine($"{i} - FizzBuzz");
//     }
//     else if( i % 3 == 0 )
//     {
//         Console.WriteLine($"{i} - Fizz");
//     }
//     else if ( i % 5 == 0)
//     {
//         Console.WriteLine($"{i} - Buzz");
//     }
//     else
//     {
//         Console.WriteLine(i);
//     }
// }

// ARRAYS AND LISTS
// string[] colors = {"red", "green", "blue"};
// int[] scores = new int[4];

// Console.WriteLine(colors[0]);
// Console.WriteLine(colors[2]);

// colors[0] = "purple";
// Console.WriteLine(colors[0]);

// Console.WriteLine(colors.Length);

// int[] scores = {95, 82, 76, 91};

// foreach (int score in scores)
// {
//        Console.WriteLine(score);
// }

// List<string> colors = new List<string> {"red", "green", "blue"};
// List<int> scores = new List<int>();

// Console.WriteLine(colors.Count);
// colors.Add("yellow");
// Console.WriteLine(colors.Count);

// colors.Remove("red");
// colors[0] = "purple";

// List<int> scores = new List<int> {95, 82, 76, 91};

// foreach(int score in scores)
// {
//        Console.WriteLine(score);
// }

// WRITE REUSABLE CODE 
// void Greet()
// {
//        Console.WriteLine("Hello, world");
// }

// Greet();

// void Greet(string name)
// {
//        Console.WriteLine($"Hello, {name}!");
// }

// Greet("Alex");
// Greet("Sam");

// void Greet(string name, string greeting)
// {
//        Console.WriteLine($"{greeting}, {name}!");
// }

// Greet("Alex", "Hi");

// void Greet(string name, string greeting = "Hello")
// {
//        Console.WriteLine($"{greeting}, {name}!");
// }

// Greet("Alex");
// Greet("Alex", "Welcome");

// NOTE: yOU CAN ALSO PASS ARGUMENTS BY NAME
// Greet(name: "Alex", greeting: "Welcome");

// int Add(int a, int b)
// {
//        return a + b;
// }

// int result = Add(3, 4);
// Console.WriteLine(result);
// Console.WriteLine(Add(10, 5) * 2);

// void Add(int a, int b)
// {
//        Console.WriteLine(a + b);    // Shows the result, but doesn't return it
// }

// int x = Add(3, 4);    // Compile error: Add doesn't return a value

// NOTE: A METHOD CAN RETURN MORE THAN ONE VALUE USING A TUPLE. NAME EACH PART SO THE CALLLER CAN READ THE RESULT CLEARLY.
// (double x, double y) GetCoodinates()
// {
//        return (10.0, 20.0);
// }

// var (x, y) = GetCoodinates();
// Console.WriteLine($"x: {x}, y: {y}");

//NAMESPACES
// using System.Text;

// StringBuilder builder = new StringBuilder();
// builder.Append("Hello, ");
// builder.Append("world!");
// Console.WriteLine(builder.ToString());

// using Day2;

// Console.WriteLine(Calculator.Add(2, 3));

// using Calc = Day2.Calculator; // Can alias if namespace is long or classes with another name with using and =

// Console.WriteLine(Calc.Add(2, 3));

