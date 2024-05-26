//Exercises: Control Flow & Collections

//TODO: Write your code for Dictionary Practice below:

Console.WriteLine("Hello, Dictionary!");

Dictionary <int,string> students = new Dictionary<int, string>();
int number = 0;



while(true)
{
    Console.Write("Please enter student Name: ");

    string studentName = Console.ReadLine();

    if (studentName != "")
    {
        Console.Write("ID: ");
        int studentId = int.Parse(Console.ReadLine());
        students.Add(studentId, studentName);
        number++;
    }
    else
    {
        break;
    }
}

Console.WriteLine("\nHere is the student list:");
foreach(KeyValuePair<int,string> student in students)
{
    Console.WriteLine(student.Value + "  " + student.Key);
}

Console.WriteLine("The student list has " + number + " students.");


