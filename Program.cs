using System;
using Membership_BusinessDataLogic;

namespace ChurchMembershipForm
{
    internal class Program
    {
        static string[] actions = new string[] { "[1] Add Member", "[2] View Members", "[3] Cancel Membership", "[4] Exit" };
        static void Main(string[] args)
        {
            Console.WriteLine("SOUTH CITY HOMES CHRISTIAN BIBLE CHURCH");
            Console.WriteLine("Church Membership Form\n");

            while (true)
            {
                DisplayOption();
                Console.Write("Enter Option: ");
                int userAction = Convert.ToInt16(Console.ReadLine());
                switch (userAction)
                {
                    case 1:
                        AddMember();
                        break;

                    case 2:
                        ViewMembers();
                        break;

                    case 3:
                        CancelMembership();
                        break;

                    case 4:
                        Console.WriteLine("Exit");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter between 1 - 3 only");
                        break;
                }
            }

        }
        static void DisplayOption()
        {

            foreach (var action in actions)
            {
                Console.WriteLine(action);
            }

            Console.WriteLine("----------------------------");
        }
        static void AddMember()
        {
            Console.Write("Name: ");
            string Name = Console.ReadLine();

            Console.Write("Age: ");
            string Age = Console.ReadLine();

            Console.Write("Birthdate [YYYY-MM-DD]: ");
            string Birthdate = Console.ReadLine();

            Console.Write("Address: ");
            string Address = Console.ReadLine();

            Console.Write("Gmail: ");
            string Gmail = Console.ReadLine();


            BusinessDataLogic.AddMember(Name, Age, Birthdate, Address, Gmail);
            Console.WriteLine("Successfully Added!\n");
            Console.WriteLine("----------------------------");
        }
        static void ViewMembers()
        {
            List<string> Members = BusinessDataLogic.GetMembers();
            if (Members.Count == 0)
            {
                Console.WriteLine("The List Is EMPTY\n");
            }
            else
            {
                Console.Write("List of Members\n");
                for (int m = 0; m < Members.Count; m++)
                {
                    Console.WriteLine(m + 1 + ". " + Members[m]);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("----------------------------");
        }
        static void CancelMembership()
        {
            List<string> Members = BusinessDataLogic.GetMembers();
            if (Members.Count == 0)
            {
                Console.WriteLine("The List Is EMPTY\n");
                return;
            }
            Console.Write("Enter name of member to cancel: ");
            string name = Console.ReadLine();

            bool removed = BusinessDataLogic.CancelMember(name);

            if (removed)
            {
                Console.WriteLine("Membership Cancelled\n");
            }
            else
            {
                Console.WriteLine("Member not found.\n");
            }
            Console.WriteLine("---------------------");
        }
    }
}