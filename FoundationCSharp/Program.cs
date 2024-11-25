using System.Security.Cryptography.X509Certificates;

namespace FoundationCSharp
{
    internal class Program
    {
        class BankAmmount
        {

            private double balance;

            public void Deposit(double amt)
            {
                if (amt > 0)
                {
                    balance += amt;
                    Console.WriteLine($"current amt:{amt}. The new balance is:{balance}");

                }
                else
                {
                    Console.WriteLine("the ammount must be postive");
                }


            }
            public double GetBalance()
            {
                return balance;
            }
        }




        static void Main(string[] args)
        {
            BankAmmount bank = new BankAmmount();
            bank.Deposit(500);

            Console.WriteLine($"Your total  balance is {bank.GetBalance()}");
        }
    }
}
