using System;

namespace Composable
{
    // declare the delegate type
    public delegate void MyDelegate(int arg1, int arg2);

    class Program
    {
        static void func1(int arg1, int arg2)
        {
            string result = (arg1 + arg2).ToString();
            Console.WriteLine("The number from func1 is: " + result);
        }
        static void func2(int arg1, int arg2)
        {
            string result = (arg1 * arg2).ToString();
            Console.WriteLine("The number from func2 is: " + result);
        }
        static void Main(string[] args)
        {
            MyDelegate f1 = func1;
            MyDelegate f2 = func2;
            // Create a composed delegate from f1 and f2

            int a=10;
            int b=20;

            // call each delegate and then the chain
            Console.WriteLine("Calling the first delegate");
            f1(a, b);
            Console.WriteLine("Calling the second delegate");
            f2(a, b);
            // TODO: Call the composed delegate
            Console.WriteLine("\nCalling the chained delegates");


            // TODO: subtract off one of the delegates
            Console.WriteLine("\nCalling the unchained delegates");

        }
    }
}
