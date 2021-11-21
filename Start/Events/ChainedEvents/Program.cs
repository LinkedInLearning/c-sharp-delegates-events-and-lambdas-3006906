using System;

namespace ChainedEvents
{
    // define the delegate for the event handler
    public delegate void myEventHandler(string value);

    class EventPublisher
    {
        private string theVal;
        // declare the event handler
        public event myEventHandler valueChanged;
        // TODO: Use the EventArgs class


        public string Val
        {
            set {
                this.theVal = value;
                // when the value changes, fire the event
                this.valueChanged(theVal);
                // TODO: Use the custom event handler

            }
        }
    }

    // TODO: Create a subclass of EventArgs for our use

    class Program
    {
        static void Main(string[] args)
        {
            // create the test class
            EventPublisher obj = new EventPublisher();
            // TODO: Connect multiple event handlers


            // TODO: Use an anonymous delegate as the event handler


            // TODO: Listen for the custom event we defined with EventArgs


            string str;
            do {
                Console.WriteLine("Enter a value: ");
                str = Console.ReadLine();
                if (!str.Equals("exit")) {
                    obj.Val = str;
                }
            } while (!str.Equals("exit"));
            Console.WriteLine("Goodbye!");
        }

        static void changeListener1(string value)
        {
            Console.WriteLine("The value changed to {0}", value);
        }
        static void changeListener2(string value)
        {
            Console.WriteLine("I also listen to the event, and got {0}", value);
        }
    }
}