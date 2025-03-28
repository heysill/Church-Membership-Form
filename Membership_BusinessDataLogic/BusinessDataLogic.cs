using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Membership_BusinessDataLogic
{
    public class BusinessDataLogic
    {
        public static List<string> Members = new List<string>();

        public static void AddMember(string Name, string Age, string Birthdate, string Address, string Gmail)
        {
            Members.Add(Name + ", " + Age + ", " + Birthdate + ", " + Address + ", " + Gmail);
        }

        public static bool CancelMember(string cancelMember)
        {
            for (int n = 0; n < Members.Count; n++)
            {
                if (Members[n].StartsWith(cancelMember + ","))
                {
                    Members.RemoveAt(n);
                    return true;
                }
            }
            return false;
        }
        public static List<string> GetMembers()
        {
            return Members;
        }
    }
}