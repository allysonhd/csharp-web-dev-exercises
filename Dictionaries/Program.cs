//Exercises: Control Flow & Collections

//TODO: Write your code for Dictionary Practice below:

Console.WriteLine("Hello, Dictionary!");

Dictionary<int, string> students = new Dictionary<int, string>();

string newStudent;

do
{ 
    Console.WriteLine("Enter Student Name (or click ENTER to exit program): ");
    string studentName = Console.ReadLine();
    newStudent = studentName;
    
    if (!Equals(newStudent, ""))
    {
        Console.WriteLine("Student ID: ");
        string idInput = Console.ReadLine();
        int studentId = int.Parse(idInput);
        students.Add(studentId, newStudent);

        Console.ReadLine(); //for the user to exit the system
    }
} while(!Equals(newStudent, ""));

Console.WriteLine("\nClass roster: ");

    foreach (KeyValuePair<int, string> student in students)
    {
        Console.WriteLine(student.Key + ":" + student.Value);
    }
Console.WriteLine("Total students: " + students.Count);

