namespace Classes;

public class Course
{

    private string Topic {get; set;}
    private string Instructor {get; set;}
    private List<Student> EnrolledStudents {get; set;}


    
    public Course(string topic, string instructor, List<Student> enrolledStudents)
    {
        this.Topic = topic;
        this.Instructor = instructor;
        this.EnrolledStudents = enrolledStudents;
    }
}
