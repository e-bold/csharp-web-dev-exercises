//Classes part 2 exercises

// TODO: Test your exercise solutions with print statements here.

using Classes_Part_2;
//Creating instances of students
Student student1 = new Student ("Jacob",1,35,4);
Student student2 = new Student ("Harry",2,95,4);
Student student3 = new Student ("Peter",3,85,4);
Student student4 = new Student ("Liam",4,20,4);
Student student5 = new Student ("Barbara",5,65,4);
Student student6 = new Student("Christian", 6, 56, 4);




//Creating instances of teachers
Teacher teacher1 = new Teacher("Lyudmila", "Borisovna", "History", 20);
Teacher teacher2 = new Teacher("Galina", "Vladimirovna", "Literature", 25);
Teacher teacher3 = new Teacher("Olga", "Knyazeeva", "Algebra", 15);






List<Student> enrolledStudents1 = new List<Student> 
{
    student1,
    student2,
    student3,
    student4,
    student5,
    student6
};

List<Student> enrolledStudents2 = new List<Student>
{
    student1,
    student3,
    student5
};
List<Student> enrolledStudents3 = new List<Student>
{
    student5,
    student6,
    student5
};

//Creating course instances
Course course1 = new Course("History", teacher1, enrolledStudents1);
Course course2 = new Course("Geology", teacher2, enrolledStudents2);
Course course3 = new Course("Biology", teacher3, enrolledStudents3);





//Checking getgrade level method that takes number of credits as an argument
Console.WriteLine(student1.Name+ " is a " + student1.GetGradeLevel(student1.NumberOfCredits));
Console.WriteLine(student2.Name+ " is a " + student2.GetGradeLevel(student2.NumberOfCredits));
Console.WriteLine(student3.Name+ " is a " + student3.GetGradeLevel(student3.NumberOfCredits));
Console.WriteLine(student4.Name+ " is a " + student4.GetGradeLevel(student4.NumberOfCredits));
Console.WriteLine(student5.Name+ " is a " + student5.GetGradeLevel(student5.NumberOfCredits));


//Testing addgrade method. Student1's initial GPA was 4.0 and took a class below(credit hours, 3.0) and dropped his gpa to 3.89
student1.AddGrade(4, 3.0);
Console.WriteLine(student1.Gpa);


//Testing to string method from Students class
Console.WriteLine(student2.ToString());

//Testing equals() method from Students class
Console.WriteLine("Checking if student1 object equals student2 object : " + student1.Equals(student2));

//Testing to string method from Course class
Console.WriteLine(course1.ToString());
Console.WriteLine(course2.ToString());
Console.WriteLine(course3.ToString());


//Testing equals() method from Course class
Console.WriteLine("Checking if course1 object equals course2 object : " + course1.Equals(course2));








