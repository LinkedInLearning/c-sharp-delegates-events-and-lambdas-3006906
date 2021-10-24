using System;

namespace EventsSolution
{
    public delegate void BalanceEventHandler(decimal theValue);

    class PiggyBank
    {
        private decimal m_bankBalance;
        public event BalanceEventHandler balanceChanged;

        public decimal theBalance
        {
            set
            {
                m_bankBalance = value;
                balanceChanged(value);
            }
            get
            {
                return m_bankBalance;
            }
        }
    }

    class BalanceLogger
    {
        public void balanceLog(decimal amount)
        {
            Console.WriteLine("The balance amount is {0}", amount);
        }
    }

    class BalanceWatcher
    {
        public void balanceWatch(decimal amount)
        {
            if (amount > 500.0m)
                Console.WriteLine("You reached your savings goal! You have {0}", amount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PiggyBank pb = new PiggyBank();
            BalanceLogger bl = new BalanceLogger();
            BalanceWatcher bw = new BalanceWatcher();

            pb.balanceChanged += bl.balanceLog;
            pb.balanceChanged += bw.balanceWatch;

            string theStr;
            do
            {
                Console.WriteLine("How much to deposit?");

                theStr = Console.ReadLine();
                if (!theStr.Equals("exit"))
                {
                    decimal newVal = decimal.Parse(theStr);

                    pb.theBalance += newVal;
                }
            } while (!theStr.Equals("exit"));
        }
    }
}
