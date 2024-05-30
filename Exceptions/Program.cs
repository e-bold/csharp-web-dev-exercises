// --------- Divide By Zero! ----------


using System.ComponentModel;

static double Divide(double x, double y)
{
    if(y == 0.0)
    {
        throw new ArgumentOutOfRangeException("y", "Value can't be zero");
    } 
    else
    {
        return x / y;
    }
}


Console.WriteLine(Divide(5,2));


// --------- Test Student Labs ----------


static int CheckFileExtension(string fileName)
{
    // Write your code here!
    if (fileName == null || fileName == "")
    {
        throw new ArgumentNullException("filename", "Student did not submit any work!");
    }
    else
    {
        if (fileName.Contains(".cs"))
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}


// Test out your CheckFileExtension() function here!


Dictionary<string, string> students = new Dictionary<string, string>();
students.Add("Carl", "Program.cs");
students.Add("Brad", "");
students.Add("Elizabeth", "MyCode.cs");

static void Catch (Dictionary<string, string> studentList)
{
    foreach(KeyValuePair<string, string> student in studentList)
    {
        try
        {
            int points = CheckFileExtension(student.Value);
            Console.WriteLine("Student - " + student.Key + " submitted " + student.Value + " and got " + CheckFileExtension(student.Value) + " points.");
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine("Student - " + student.Key + " Error: " + e.Message);
        }
    }
}

Catch(students);






