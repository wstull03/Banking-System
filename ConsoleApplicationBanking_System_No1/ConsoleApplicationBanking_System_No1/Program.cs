using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationBanking_System_No1
{
    class Program
    {
        static void Main(string[] args)
        {

            Clients clients = new Clients();
            Accounts accounts = new Accounts();
            StreamWriter writer = new StreamWriter("AccountSummary.txt");

            using (writer)
            {
               
                writer.WriteLine("BANKING SYSTEM");
                writer.WriteLine("**************");
                writer.WriteLine(clients.FullName + " " + "No."+ accounts.AccountNumber);
                writer.WriteLine();
            }

            int userChoice = 0;

            do
            {               
                Console.WriteLine();
                Console.WriteLine("BANKING SYSTEM");
                Console.WriteLine("**************");
                Console.WriteLine("1 - View Client Information\n2 - View Account Balance\n3 - Deposit Funds\n4 - Withdraw Funds\n5 - Exit");
                int.TryParse(Console.ReadLine(), out userChoice);

                switch (userChoice)
                {

                    case 1:

                        clients.viewClientInformation();
                        break;

                    case 2:

                        accounts.viewAccountDetails();
                        break;

                    case 3:

                        accounts.deposit();
                        break;

                    case 4:

                        accounts.withdraw();
                        break;

                    case 5:

                        Console.WriteLine();
                        Console.WriteLine("Goodbye");
                        Console.WriteLine();
                        break;

                    default:

                        break;

                }

            } while (userChoice != 5);

        }
    }
}
