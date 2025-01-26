namespace Homework1;

class Program
{
    static void Main(string[] args)
    {
        //The linear line equation is Z=4X^2 + 3Y , when X = 2.5, Y = 3.3
        double X = 2.5;
        double Y = 3.3;

        double Z = 4*X*X + 3*Y;

        Console.WriteLine("X = 2.5, Y = 3.3");
        Console.Write("The value of Z is: ");
        Console.Write(Z);
    }  

}