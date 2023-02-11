using System;
using System.Collections.Generic;
using System.Text;

namespace GameTesting
{
    public class GameToTest : IGameToTest
    {
        private static int nextProjectID = 1000;
        public static int NextProjectID { get { return nextProjectID; } }
        public int ProjectID { get; }
        public String Name { set; get; }
        public GENRE Genre { set; get; }
        public String Description { set; get; }
        public Client Client { set; get; }
        public Employee Supervisor { set; get; }
        private List<Employee> employees;

        public GameToTest() : this("NAMELESS")
        {

        }

        // Designated Constructor
        public GameToTest(String name)
        {
            ProjectID = nextProjectID++;
            Name = name;
            employees = new List<Employee>();
        }

        public bool AddEmployee(Employee employee)
        {
            bool success = false;
            if(employee != null)
            {
                employees.Add(employee);
                success = true;
            }
            return success;
        }

        public String EmployeeList
        {
            get
            {
                String output = "\n*** Employee List ***\n";
                foreach(Employee employee in employees)
                {
                    output += employee.FullName + "\n";
                }
                return output;
            }
        }
        override public String ToString()
        {
            String output = "ProjectID = " + ProjectID + "\n";
            output += "Name = " + Name + "\n";
            output += "Genre = " + Genre + "\n";
            output += "Description = " + Description + "\n";
            output += "Client = " + (Client != null?Client.FullName:"NO CLIENT") + "\n";
            output += "Supervisor = " + (Supervisor != null?Supervisor.FullName:"NO SUPERVISOR") + "\n";
            return output;
        }

    }
}
