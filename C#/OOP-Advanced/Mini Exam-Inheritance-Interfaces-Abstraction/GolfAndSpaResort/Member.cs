using System;
using System.Collections.Generic;
using System.Text;

namespace GolfAndSpaResort
{
    public class Member : Customer
    {
        private int membershipId;

        public int MembershipId
        {
            get { return membershipId; }
            set { membershipId = value; }
        }

        public Member(string firstName, string lastName, int membershipId) : base(firstName, lastName)
        {
            this.MembershipId = membershipId;
        }

        public void GetMemberCard(string freeAccess)
        {
            Console.WriteLine($"Member {FirstName} {LastName} with membership number {MembershipId} gets free access to the {freeAccess}.");
        }
    }
}
