using System;

namespace BasicDelegates
{
    // declare the delegate type
    public delegate string MyDelegate(int arg1, int arg2);

    class MyClass
    {
        // Delegates can be bound to instance members as well as
        // static class functions
        public string instanceMethod1(int arg1, int arg2)
        {
            return ((arg1 + arg2) * arg1).ToString();
        }
    }

    class Program
    {
        static string func1(int a, int b)
        {
            return (a + b).ToString();
        }
        static string func2(int a, int b)
        {
            return (a * b).ToString();
        }

        static void Main(string[] args)
        {
            MyDelegate f = func1;
            Console.WriteLine("The number is: " + f(10, 20));
            f = func2;
            Console.WriteLine("The number is: " + f(10, 20));

            MyClass mc = new MyClass();
            f = mc.instanceMethod1;
            Console.WriteLine("The number is: " + f(10, 20));

            Console.WriteLine("\nPress Enter Key to Continue...");
            Console.ReadLine();
        }
    }
}
