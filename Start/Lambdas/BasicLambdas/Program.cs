using System;

namespace BasicLambdas
{
    // define a few delegate types
    public delegate int MyDelegate(int x);
    public delegate void MyDelegate2(int x, string prefix);
    public delegate bool ExprDelegate(int x);

    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create a basic delegate that squares a number

            // TODO: Dynamically change the delegate to something else

            // TODO: Create a delegate that takes multiple arguments

            // TODO: Define an expression delegate

            // Keep the Command Line window open
            Console.WriteLine("\nPress Enter Key to Continue...");
            Console.ReadLine();
        }
    }
}