using System;
using System.Collections.Generic;
using System.Text;

namespace NameReference
{
    public class User
    {
        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Initials => $"{FirstName?[0]}{LastName?[0]}";
    }
}
