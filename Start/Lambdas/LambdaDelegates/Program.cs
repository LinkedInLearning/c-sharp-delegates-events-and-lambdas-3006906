using System;

namespace LambdaDelegates
{
    // define a delegate 
    public delegate void myEventHandler(string value);

    class MyClass
    {
        private string theVal;
        public event myEventHandler valueChanged;

        public string Val
        {
            set
            {
                this.theVal = value;
                // when the value changes, fire the event
                this.valueChanged(theVal);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();

            // TODO: Use a Lambda expression to define an event handler
            // Note that this is a statement lambda, due to use of { }


            string str;
            do {
                str = Console.ReadLine();
                if (!str.Equals("exit"))
                {
                    obj.Val = str;
                }
            } while (!str.Equals("exit"));

            Console.WriteLine("Goodbye!");
        }
    }
}
