//Exercises: Control Flow & Collections

//TODO: Write your code for String Practice below:

Console.WriteLine("Hello, Strings!");

string text = @"I would not, could not, in a box. I would not, could not with a fox.
I will not eat them in a house. I will not eat them with a mouse.";

// Console.WriteLine(text);

string[] spaceArray = text.Split(" ");
// Console.WriteLine(string.Join(",", spaceArray));

string[] sentenceArray = text.Split(".");
Console.WriteLine(string.Join(";", sentenceArray));