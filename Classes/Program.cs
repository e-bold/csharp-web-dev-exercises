// TODO: Instantiate your objects and test your exercise solutions with print statements here.
using Classes;

Student enkhmunkh = new Student("Enkhmunkh",1,5,4.0);
Student zachariah = new Student("Zach");
Student peter = new Student("Peter");
peter.NumberOfCredits = 25;
Console.WriteLine("The Student class works! " + enkhmunkh.Name + " is a student! " + "His student id is " + enkhmunkh.StudentId);
Console.WriteLine("The Student class works! " + zachariah.Name + " is a student! " + "His student id is " + zachariah.StudentId);
Console.WriteLine("The Student class works! " + peter.Name + " is a student! " + "His student id is " + peter.StudentId + " and his number of credits is " + peter.NumberOfCredits);


List<Student> students = new()
{
    enkhmunkh,
    zachariah,
    peter
};

Course subject = new Course("Geology", "Bailey", students);

foreach(Student student in students)
{
    Console.WriteLine(student.Name);
}

