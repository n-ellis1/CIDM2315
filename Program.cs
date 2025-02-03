namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        // Ask to input a letter
        Console.Write("Please input a letter grade: (A, B, C, D, F): ");
        string grade = Console.ReadLine().ToUpper(); // Converts to uppercase for case-insensitivity

        // Check the grade and output corresponding GPA points
        if (grade == "A")
        {
            Console.WriteLine("GPA point: 4");
        }
        else if (grade == "B")
        {
            Console.WriteLine("GPA point: 3");
        }
        else if (grade == "C")
        {
            Console.WriteLine("GPA point: 2");
        }
        else if (grade == "D")
        {
            Console.WriteLine("GPA point: 1");
        }
        else if (grade == "F")
        {
            Console.WriteLine("GPA point: 0");
        }
        else
        {
            Console.WriteLine("Wrong Letter Grade!");
        }

        //Question 2:
        // Ask the user to input three numbers
        Console.Write("Please input the first num: ");
        int num1 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Please input the second num: ");
        int num2 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Please input the third num: ");
        int num3 = Convert.ToInt16(Console.ReadLine());

        // Find the smallest number using nested if statements
        int smallest;
        
        if (num1 <= num2)
        {
            if (num1 <= num3)
            {
                smallest = num1;  
            }
            else
            {
                smallest = num3;  
            }
        }
        else
        {
            if (num2 <= num3)
            {
                smallest = num2;  
            }
            else
            {
                smallest = num3;  
            }
        }

        // Print the smallest value
        Console.WriteLine("The smallest value is: " + smallest);
    }
}
