using MembershipCommon;

namespace MembershipDataAccess
{
    public class MemberAccess
    {
        private static List<Member> members = new List<Member>();
        public static void Add(Member member)
        {
            members.Add(member);
        }
        public static bool Remove(string name)
        {
            var member = members.Find(m => m.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (member != null)
            {
                members.Remove(member);
                return true;
            }
            return false;
        }
        public static Member Get(string name)
        {
            return members.Find(m => m.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
        public static List<Member> GetAll()
        {
            return new List<Member>(members);
        }
        public static bool Update(string oldName, Member updatedMember)
        {
            var existing = members.Find(m => m.Name.Equals(oldName, StringComparison.OrdinalIgnoreCase));
            if (existing != null)
            {
                existing.Name = updatedMember.Name;
                existing.Age = updatedMember.Age;
                existing.Birthdate = updatedMember.Birthdate;
                existing.Address = updatedMember.Address;
                existing.Gmail = updatedMember.Gmail;
                return true;
            }
            return false;
        }
    }
}
