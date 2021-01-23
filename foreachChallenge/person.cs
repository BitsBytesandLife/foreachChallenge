using System;
using System.Collections.Generic;
using System.Text;

namespace foreachChallenge
{
    public class person
    {
        public person( string FirstName, string LastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }

        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
