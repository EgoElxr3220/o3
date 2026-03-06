internal class Program
{
    private static void Main(string[] args)
    {
        Teacher teacher = new Teacher("Greg Hanson");
        teacher.AddStudent(new Student("Brett", 88));
        teacher.AddStudent(new Student("Brad", 85));
        teacher.AddStudent(new Student("Sarah", 98));
        teacher.DisplayStudents();
    }
}

public class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }

    public Student(string name, int grade)
    {
        Name = name;
        Grade = grade;
    }
}

public class Teacher
{
    public string Name { get; set; }
    public static List<Student> Students = new List<Student>();

    public Teacher(string name)
    {
        Name = name;
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public void DisplayStudents()
    {
        foreach (Student student in Students)
        {
            Console.WriteLine($"{student.Name}: {student.Grade}");
        }
    }
}