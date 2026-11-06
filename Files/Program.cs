//             //OPEN AND CLOSE FILES SAFELY WITH USING
// try
// {
//     StreamReader reader = new StreamReader("notes.txt");
//     string contents = reader.ReadToEnd();
//     Console.WriteLine(contents);
//     reader.Close();

//     //USING 'USING' IS THE SAFER WAY TO WORK WITH FILES. IT AUTOMATICALLY CLOSES THE FILE.
//     using(StreamReader reader2 = new StreamReader("notes.text"))
//     {
//         string contents2 = reader2.ReadToEnd();
//         Console.WriteLine(contents2);
//     } // File is automatically closed here

//     //SHORTER USING DECLARATION WITHOUT NEEDING BRACES IS SUPPORTED IN MODERN C#
//     using StreamReader reader3 = new StreamReader("notes.txt");
//     string contents3 = reader3.ReadToEnd();
//     Console.WriteLine(contents3);
//     //File is automatically closed at the end of this block

//     //AN EVEN SIMPLER OPTION IS USNG THE 'FILE' CLASS
//     //IT PROVIDES STATIC METHODS THAT OPEN, READ OR WRITE, AND CLOSE A FILE IN A SINGLE CALL WITHOUT NEEDING AN EXPLICIT 'USING' STATEMENT
//     string contents4 = File.ReadAllText("notes.txt");
//     Console.WriteLine(contents4);

// }
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine(ex.Message);
// }

            // WRITE DATA TO FILES

    // CREATES A NEW FILE OR COMPLETELY OVERWRITES AN EXISTING FILE WITH THE SAME NAME.
// File.WriteAllText("greeting.txt", "Hello, world\n");

    // ADDS TO THE END OF THE FILE KEEPING ANYTHING THAT IS ALREADY THERE. IF THE FILE DOESN'T EXIST YET, C# CREATES IT
// File.AppendAllText("greeting.txt", "I'm greeting from dotnet\n");

    // USE 'STREAMWRITER' WITH USING TO WRITE MULTIPLE LINES
string[] tasks = {"Buy groceries", "Walk the dog", "Finish homework"};

using StreamWriter writer = new StreamWriter("tasks.txt", append : false);

foreach (var task in tasks)
{
    writer.WriteLine(task);  // NOTE: This method adds a newline after each entry automatically unlike the .Write().
}

