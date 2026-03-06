internal class Program
{
    private static void Main(string[] args)
    {
        
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
    public List<Student> Students { get; set; }

    public Teacher(string name, List<Student> students)
    {
        Name = name;
        Students = students;
    }

    public static void AddStudent(Student student)
    {

    }

    public static void DisplayStudents()
    {

    }
}