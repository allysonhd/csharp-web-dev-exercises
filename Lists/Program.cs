//Exercises: Control Flow & Collections

//TODO: Write your code for List Practice below:

Console.WriteLine("Hello, Lists!");

/*Write a static method to find the sum of all the even numbers in a List.
Create a list with at least 10 integers and call your method on the list.*/

List<double> numbers = new List<double>();

numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);
numbers.Add(6);
numbers.Add(7);
numbers.Add(8);
numbers.Add(9);
numbers.Add(10);

double sumEvenNumbers = 0;

foreach (double number in numbers)
{
    if (number % 2 == 0)
    {
        sumEvenNumbers += number;
    }
}
Console.WriteLine(sumEvenNumbers);


static double SumNumbers(List<double> numbers)
{
    double total = 0;
    foreach (double number in numbers)
    {
        if (number % 2 == 0)
        {
            total += number;
        }
    } return total;
}

double methodTotal = SumNumbers(numbers);
Console.WriteLine(methodTotal);


//Write a static method to print out each word in a list that has exactly 5 letters.
List<string> seaLife = new List<string>();

seaLife.Add("whale");
seaLife.Add("otter");
seaLife.Add("kelp");
seaLife.Add("urchin");  
seaLife.Add("puffin"); 
seaLife.Add("shark");   
seaLife.Add("slug");
seaLife.Add("anemone"); 
seaLife.Add("coral");

static List<string> FiveLetters(List<string> seaLife)
{
    List<string> seaLifeFive = new List<string>();

    foreach (string creature in seaLife)
    {
        if (creature.Length == 5)
        {
            seaLifeFive.Add(creature);
        }
    }

    return seaLifeFive;
}

List<string> fiveLetterSeaCreatures = FiveLetters(seaLife);
foreach (string creature in fiveLetterSeaCreatures)
{
    Console.WriteLine(creature);
}
Console.WriteLine(string.Join(",",fiveLetterSeaCreatures));

//Modify your code to prompt the user to enter the word length for the search.

string userInput;

List<string> userCreatures = new List<string>();
Console.WriteLine("Enter a length for the word search: ");

userInput = Console.ReadLine();
int userLength = int.Parse(userInput);

foreach (string creature in seaLife)
{
    if (userLength == creature.Length)
    {
        userCreatures.Add(creature);
    }
}
if (userCreatures.Count > 0)
{
    Console.WriteLine(string.Join(",", userCreatures));
}
else
{
    Console.WriteLine("Sadly, there are no creatures that match your search. Please try again!");
}

//alternative using a method

PrintUserWords(seaLife, userLength);
static void PrintUserWords(List<string> seaLife, int userLength)
{
    foreach (string creature in seaLife)
    {
        if (userLength == creature.Length)
        {
            Console.WriteLine(creature);
        }
    }
}