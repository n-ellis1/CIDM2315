namespace Homework9;

public class Student
{
    private int studentID;
    private string studentName;

    // Constructor that initializes the student ID and name
    public Student(int id, string name)
    {
        studentID = id;
        studentName = name;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }

    // Getter for the student name
    public string GetStudentName()
    {
        return studentName;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Student s1 = new Student(111, "Alice");
        Student s2 = new Student(222, "Bob");
        Student s3 = new Student(333, "Cathy");
        Student s4 = new Student(444, "David");

        // Maintain a list of student objects for later printing.
        List<Student> allStudents = new List<Student> { s1, s2, s3, s4 };

        Dictionary<string, double> gradebook = new Dictionary<string, double>();

        gradebook[s1.GetStudentName()] = 4.0; // Alice
        gradebook[s2.GetStudentName()] = 3.6; // Bob
        gradebook[s3.GetStudentName()] = 2.5; // Cathy
        gradebook[s4.GetStudentName()] = 1.8; // David

        // Check for "Tom" and add him if he is not in the dictionary.
        if (!gradebook.ContainsKey("Tom"))
        {
            // Create a Student object for Tom.
            Student tom = new Student(555, "Tom");
            gradebook[tom.GetStudentName()] = 3.3;
            allStudents.Add(tom);
        }

        // Compute the average GPA of all students in the dictionary.
        double totalGPA = 0;
        foreach (var entry in gradebook)
        {
            totalGPA += entry.Value;
        }
        double averageGPA = totalGPA / gradebook.Count;
        Console.WriteLine($"The average GPA is: {averageGPA:F2}");

        // Print the ID and name of all students whose GPA is greater than the average GPA.
        Console.WriteLine("\nStudents with GPA above the average:");
        foreach (Student student in allStudents)
        {
            if (gradebook[student.GetStudentName()] > averageGPA)
            {
                student.PrintInfo();
            }
        }
    }
}
