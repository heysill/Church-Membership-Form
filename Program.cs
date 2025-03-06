using System;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace ChurchMembershipForm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Members = new List<string>();

            Console.WriteLine("Church Membership Form");

            while (true)
            {
                string[] actions = new string[] { "[1] Add", "[2] View", "[3] Exit" };

                Console.WriteLine("ACTIONS");

                foreach (var action in actions)
                {
                    Console.WriteLine(action);
                }
                Console.Write("Enter Action: ");
                int userAction = Convert.ToInt16(Console.ReadLine());
                switch (userAction)
                {
                    case 1:
                        Console.Write("Name: ");
                        string Name = Console.ReadLine();

                        Console.Write("Age: ");
                        string Age = Console.ReadLine();

                        Console.Write("Birthdate: ");
                        string Birthdate = Console.ReadLine();

                        Console.Write("Address: ");
                        string Address = Console.ReadLine();

                        Console.Write("Gmail: ");
                        string Gmail = Console.ReadLine();
                        Members.Add(Name + ", " + Age + ", " + Birthdate + ", " + Address + ", " + Gmail);
                        break;

                    case 2:
                        Console.Write("List of Members\n");

                        foreach (var Member in Members)
                        {
                            Console.WriteLine(Member);
                        }
                        break;

                    case 3:
                        Console.WriteLine("Exit");
                        return;
              
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option");
                        break;
                }
            }
            
        }
    }
}

