using System;

namespace BasicDelegates
{
    // TODO: declare the delegate type


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
        // TODO: Create functions to serve as delegate implementations


        static void Main(string[] args)
        {
            // TODO: exercise each delegate function


            // TODO: Use an instance function of a class as a delegate


        }
    }
}
