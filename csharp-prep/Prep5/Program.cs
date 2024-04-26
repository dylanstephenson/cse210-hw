using System;

class Program
{
    static void Main(string[] args)
    {

        static void main()
        {
            DisplayWelcome();
            string userName = PromptUserName();
            int favNum = PromptUserNumber();
            double squareNum = SquareNumber(favNum);
            DisplayResult(userName, squareNum);
        }

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name; 
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favNum = int.Parse(Console.ReadLine());
            return favNum;
        }
        static double SquareNumber(int number)
        {
            double squareNum = Math.Pow(number, 2);
            return squareNum;
        }
        static void DisplayResult(string name, double squareNum)
        {
            Console.WriteLine($"{name}, your number squared is {squareNum}");
        }

        main();
    }
}