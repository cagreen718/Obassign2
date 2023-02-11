using System;
using System.Collections.Generic;
using System.Text;

namespace GameTesting
{
    public class GamesToTestDB : IGamesToTestDB
    {
        private List<Employee> employees;
        private List<Client> clients;
        private List<GameToTest> gamesToTest;
        public String EmployeeList
        {
            get
            {
                String output = "\n*** Employee List ***\n";
                foreach (Employee employee in employees)
                {
                    output += employee + "\n";
                }
                return output;
            }
        }

        public GamesToTestDB()
        {
            employees = new List<Employee>();
            clients = new List<Client>();
            gamesToTest = new List<GameToTest>();
        }
        public bool CreateEmployee(String lastName, String firstName)
        {
            Employee employee = new Employee(lastName, firstName);
            employees.Add(employee);
            return true;
        }
        public bool CreateClient(String lastName, String firstName)
        {
            clients.Add(new Client(lastName, firstName));
            return true;
        }
        public bool CreateGameToTest(String name)
        {
            gamesToTest.Add(new GameToTest(name));
            return true;
        }
        public bool AssignClientToGameToTest(int gameToTestID, int clientID)
        {
            return false;
        }
        public bool AssignSupervisorToGameToTest(int gameToTestID, int employeeID)
        {
            return false;
        }
        public bool AddEmployeeToGameToTest(String lastName, String firstName, String name)
        {
            bool success = false;
            GameToTest tempGTT = FindGameToTest(name);
            if(tempGTT != null)
            {
                Employee tempEmployee = FindEmployee(lastName, firstName);

                if(tempEmployee != null)
                {
                    tempGTT.AddEmployee(tempEmployee);
                    success = true;
                }
            }
            return success;
        }
        public Employee FindEmployee(String lastName, String firstName)
        {
            Employee tempEmployee = null;
            foreach(Employee employee in employees)
            {
                if(employee.LastName.Equals(lastName) && employee.FirstName.Equals(firstName))
                {
                    tempEmployee = employee;
                }
            }

            return tempEmployee;
        }
        public GameToTest FindGameToTest(String name)
        {
            GameToTest tempGameToTest = null;
            foreach(GameToTest gameToTest in gamesToTest)
            {
                if(gameToTest.Name.Equals(name))
                {
                    tempGameToTest = gameToTest;
                }
            }

            return tempGameToTest;
        }
    }
}
