// DICTIONARY
// Dictionary<string, int> marks = new Dictionary<string, int>();

// marks.Add("Alice", 95);
// marks.Add("Bob", 82);
// marks.Add("Charlie", 76);

// Dictionary<string, int> marks = new();   // shorter target-typed syntac

// marks.Add("Alice", 95);
// marks.Add("Bob", 82);

// // Indexer way of adding 
// NOTE: ADDS ENTRY IF KEY IS NEW OR UPDATES IT IF KEY ALREADY EXISTS
// marks["Alice"] = 95;
// marks["Bob"] = 82;

// Dictionary<string, int> marks = new()
// {
//        {"Alice", 95},       
//        {"Bob", 82},
//        {"Charlie", 76}
// };     // initializes values immediately

// Console.WriteLine(marks["Alice"]);

// if (marks.ContainsKey("Alice"))
// {
//        Console.WriteLine(marks["Alice"]);
// }

// if (marks.TryGetValue("Alice", out int mark))
// {
//        Console.WriteLine(mark);
// } 
// else
// {
//        Console.WriteLine("Student not found");
// }

// if (marks.TryGetValue("David", out int mark))
// {
//        Console.WriteLine(mark);
// }
// else
// {
//        Console.WriteLine("David does not exist");
// }

// NOTE: WHICH SHOULD YOU USE?
// dictionary[key]: When you expect the key to exist.

// ContainsKey(key): When you only need to check whether the key exists.

// TryGetValue(key, out value): When you want to check and retrieve the value together.

// UPDATING VALUES
// marks["Alice"] = 100;
// Console.WriteLine(marks["Alice"]);

//can also update a value based on its current value:
// marks["Bob"] = marks["Bob"] + 5;
// Console.WriteLine(marks["Bob"]);

// REMOVING ENTRIES
// bool removed = marks.Remove("Bob"); // returns a bool indicating whether the entry was actually removed
// Console.WriteLine(marks.ContainsKey("Bob"));

// IN MODERN .NET, YOU CAN ALSO RETRIEVE THE REMOVED VALUE
// if (marks.Remove("Bob", out int removedMark))
// {
//        Console.WriteLine($"Removed mark: {removedMark}");
// }

// marks.Clear(); // removes everything
// Console.WriteLine(marks.Count);

// foreach (KeyValuePair<string, int> entry in marks)
// {
//     Console.WriteLine($"{entry.Key}: {entry.Value}");
// }

// Use var to simplify the loop. You don't have to write the full KeyValuePair type:
// foreach (var entry in marks)
// {
//     Console.WriteLine($"{entry.Key}: {entry.Value}");
// }

// CAN LOOP THROUGH ONLY KEYS
// foreach (string name in marks.Keys)
// {
//        Console.WriteLine(name);
// }

// CAN LOOP THROUGH ONLY VALUES
// foreach (int mark in marks.Values)
// {
//        Console.WriteLine(mark);
// }


// By default, a dictionary using string keys is case-sensitive. To make them case insensitive, use Use StringComparer.OrdinalIgnoreCase
// Dictionary<string, int> ages =
//     new(StringComparer.OrdinalIgnoreCase);

// ages.Add("Alice", 25);

// // ages.Add("alice", 30); // Throws: equivalent key already exists

// Console.WriteLine(ages["ALICE"]); // 25

