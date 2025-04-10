
namespace MembershipMCommon
{
    public class Member
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Birthdate { get; set; }
        public string Address { get; set; }
        public string Gmail { get; set; }

        public string ToString()
        {
            return $"{Name}, {Age}, {Birthdate}, {Address}, {Gmail}";
        }
    }
}
