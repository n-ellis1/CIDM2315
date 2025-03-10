namespace Homework6;

class Homework6
    {
        static void Main(string[] args)
        {
            Professor prof1 = new Professor("Alice", "Java", 9000);
            Professor prof2 = new Professor("Bob", "Math", 8000);


            Student student1 = new Student("Lisa", "Java", 90);
            Student student2 = new Student("Tom", "Math", 80);

            Console.WriteLine($"Professor {prof1.ProfName} teaches {prof1.ClassTeach}, and the salary is: {prof1.GetSalary()}");
            Console.WriteLine($"Professor {prof2.ProfName} teaches {prof2.ClassTeach}, and the salary is: {prof2.GetSalary()}");
            Console.WriteLine($"Student {student1.StudentName} enrolls {student1.ClassEnroll}, and the grade is: {student1.GetGrade()}");
            Console.WriteLine($"Student {student2.StudentName} enrolls {student2.ClassEnroll}, and the grade is: {student2.GetGrade()}");

            // Calculate and print the difference in salary between the two professors
            double salaryDifference = prof1.GetSalary() - prof2.GetSalary();
            Console.WriteLine($"The salary difference between {prof1.ProfName}'s {prof1.ClassTeach} course and {prof2.ProfName}'s {prof2.ClassTeach} course is: {salaryDifference}");

            // Calculate and print the total grade of Lisa and Tom
            double totalGrade = student1.GetGrade() + student2.GetGrade();
            Console.WriteLine($"The total grade of {student1.StudentName} and {student2.StudentName} is: {totalGrade}");
        }
    }

    class Professor
    {
        private string profName;
        private string classTeach;
        private double salary;

        public Professor(string name, string teach, double sal)
        {
            profName = name;
            classTeach = teach;
            salary = sal;
        }

        // Methods from UML
        public void SetSalary(double amount)
        {
            salary = amount;
        }

        public double GetSalary()
        {
            return salary;
        }

        public string ProfName
        {
            get { return profName; }
            set { profName = value; }
        }

        public string ClassTeach
        {
            get { return classTeach; }
            set { classTeach = value; }
        }
    }

    class Student
    {
        private string studentName;
        private string classEnroll;
        private int grade;

        public Student(string name, string enroll, int g)
        {
            studentName = name;
            classEnroll = enroll;
            grade = g;
        }

        // Methods from UML
        public void SetGrade(int amount)
        {
            grade = amount;
        }

        public double GetGrade()
        {
            return grade;
        }

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }

        public string ClassEnroll
        {
            get { return classEnroll; }
            set { classEnroll = value; }
        }
    }

