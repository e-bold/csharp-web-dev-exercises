using System;
namespace Classes_Part_2
{
	public class Course
	{

        public string Topic { get; set; }
        public Teacher Instructor { get; set; }
        public List<Student> enrolledStudents { get; set; }

        public Course(string topic, Teacher instructor, List<Student> enrolledStudents)
        {
            Topic = topic;
            Instructor = instructor;
            this.enrolledStudents = enrolledStudents;
        }

        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather than
        //  just the class fields.

        public override string ToString()
         {
            return Topic + " is taught by " + Instructor.FirstName +" "+ Instructor.LastName + " and has " + enrolledStudents.Count + " students enrolled in it.";
         }


        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Course objects equal.

        public override bool Equals(object obj)
         {
            if (obj == this)
            {
               return true;
            }

            if (obj == null)
            {
               return false;
            }

            if (obj.GetType() != GetType())
            {
               return false;
            }
            //This attempts to cast obj to a Student type. If the cast is successful (obj is indeed a Student), it compares the StudentId property of the current instance with that of studentObj.If the StudentId properties are equal, the method returns true; otherwise, it returns false. 
            Course studentObj = obj as Course;
            return Topic == studentObj.Topic;
         }

    }
}

