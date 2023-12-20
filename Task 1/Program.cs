using System.Security.Principal;

namespace Task1
{
    enum MenuOption
    {
        Withdraw,
        Deposit,
        Print,
        Quit
    }


    internal class Program
    {
        public static MenuOption ReadUserInput()
        {
            MenuOption userSelection;
            int userInput;

            do
            {
                Console.WriteLine("Select an Option fro 0 to 3:");
                Console.WriteLine("0 -> Withdraw");
                Console.WriteLine("1 -> Deposit");
                Console.WriteLine("2 -> Print");
                Console.WriteLine("3 -> Quit");

                userInput = Convert.ToInt32(Console.ReadLine());

            } while (userInput < 0 || userInput > 3);

            userSelection = (MenuOption)userInput;
            return userSelection;
        }

        public static void DoDeposit(Account account)
        {
            Console.Write("Enter the amount to Deposit: ");
            Decimal amountToDeposit = Convert.ToDecimal(Console.ReadLine());
            account.Deposit(amountToDeposit);
        }
        public static void DoWithdraw(Account account)
        {
            Console.Write("Enter the amount to Withdraw: ");
            decimal amountToWithdraw = Convert.ToDecimal(Console.ReadLine());
            account.Withdraw(amountToWithdraw);
        }
        public static void DoPrint(Account account)
        {
            account.Print();
        }

        static void Main(string[] args)
        {
            Account account = new Account("Jackes Account", 20000);
            account.Print();
            account.Deposit(100);
            account.Print();
            account.Withdraw(300);
            account.Print();

            Account account2 = new Account("Kareem's Account", 10000);
            account2.Print();
            account2.Deposit(100);
            account2.Print();
            account2.Withdraw(300);
            account2.Print();

            bool running = true;
            do
            {
                switch (ReadUserInput())
                {
                    case MenuOption.Withdraw:
                        DoWithdraw(account2);
                        break;

                    case MenuOption.Deposit:
                        DoDeposit(account2);
                        break;

                    case MenuOption.Print:
                        DoPrint(account2);
                        break;

                    case MenuOption.Quit:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Wrong Option");
                        break;
                }
            } while (running);
        }
    }
}
