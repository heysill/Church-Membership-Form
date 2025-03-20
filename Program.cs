using System;

namespace ChurchMembershipForm
{
    internal class Program
    {
        static List<string> Members = new List<string>();
        static string[] actions = new string[] { "[1] Add", "[2] View", "[3] Exit" };
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
            Members.Add(Name + ", " + Age + ", " + Birthdate + ", " + Address + ", " + Gmail);
            Console.WriteLine("Successfully Added!\n");
            Console.WriteLine("----------------------------");
        }
        static void ViewMembers()
        {
            if (Members.Count == 0)
            {
                Console.WriteLine("The List Is EMPTY\n");
            }
            else
            {
                Console.Write("List of Members\n");
                for (int m = 0; m < Members.Count; m++)
                {
                    Console.WriteLine(m + 1 + ". " + Members[m] + "\n");
                }
            }

            Console.WriteLine("----------------------------");
        }
    }
}

