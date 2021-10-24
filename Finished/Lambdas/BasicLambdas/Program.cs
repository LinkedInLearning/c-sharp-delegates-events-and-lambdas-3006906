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
            // Create a basic delegate that squares a number
            MyDelegate foo = (x) => x * x;
            Console.WriteLine("The result of foo is: {0}", foo(5));

            // Dynamically change the delegate to something else
            foo = (x) => x * 10;
            Console.WriteLine("The result of bar is: {0}", foo(5));

            // Create a delegate that takes multiple arguments
            MyDelegate2 bar = (x, y) =>
            {
                Console.WriteLine("The two-arg lambda: {1}, {0}", x * 10, y);
            };
            bar(25, "Some string");

            // Define an expression delegate
            ExprDelegate baz = (x) => x > 10;
            Console.WriteLine("Calling baz with 5: {0}", baz(5));
            Console.WriteLine("Calling bax with 15: {0}", baz(15));

            // Keep the Command Line window open
            Console.WriteLine("\nPress Enter Key to Continue...");
            Console.ReadLine();
        }
    }
}