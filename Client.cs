using System;
using System.Collections.Generic;
using System.Text;

namespace GameTesting
{
    public class Client : IPeople
    {
        private static int nextID = 0;
        public static int NextID { get { return nextID; } private set { nextID = value; } }
        public int Identifier { get; }
        public String FirstName { set; get; }
        public String LastName { set; get; }
        public String FullName { get { return FirstName + " " + LastName; } }

        public Client() : this("?")
        {
        }

        public Client(String lastName) : this(lastName, "?")
        {
        }

        // Designated Constructor
        public Client(String lastName, String firstName)
        {
            Identifier = nextID++;
            FirstName = firstName;
            LastName = lastName;
        }

        override public String ToString()
        {
            return Identifier + "-" + FullName;
        }
    }
}
