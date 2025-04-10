using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MembershipCommon;
using MembershipDataAccess;

namespace Membership_BusinessDataLogic
{
    public class BusinessDataLogic
    {
        public static void AddMember(string Name, string Age, string Birthdate, string Address, string Gmail)
        {
            var member = new Member
            {
                Name = Name,
                Age = Age,
                Birthdate = Birthdate,
                Address = Address,
                Gmail = Gmail
            };
            MemberAccess.Add(member);
        }

        public static bool CancelMember(string cancelMember)
        {
            return MemberAccess.Remove(cancelMember);
        }
        public static List<string> GetMembers()
        {
            return MemberAccess.GetAll().Select(m => m.ToString()).ToList();
        }
        public static bool UpdateMember(string oldName, string newName, string newAge, string newBirthdate, string newAddress, string newGmail)
        {
            var updatedMember = new Member
            {
                Name = newName,
                Age = newAge,
                Birthdate = newBirthdate,
                Address = newAddress,
                Gmail = newGmail
            };
            return MemberAccess.Update(oldName, updatedMember);
        }
        public static string SearchMember(string name)
        {
            var member = MemberAccess.Get(name);
            return member != null ? member.ToString() : null;
        }
    }
}