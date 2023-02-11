using System;
using System.Collections.Generic;
using System.Text;

namespace GameTesting
{
    public interface IPeople
    {
        int Identifier { get; }
        String FirstName { set; get; }
        String LastName { set; get; }
        String FullName { get; }
        String ToString();
    }

    public enum GENRE { ACTION, ADVENTURE, RPG, STRATEGY, PLATFORMER, PUZZLE }

    public interface IGameToTest
    {
        int ProjectID { get; }
        String Name { set; get; }
        GENRE Genre { set; get; }
        String Description { set; get; }
        Client Client { set; get; }
        Employee Supervisor { set; get; }
        bool AddEmployee(Employee employee);
        String ToString();
    }

    public interface IGamesToTestDB
    {
        String EmployeeList { get; }
        bool CreateEmployee(String lastName, String firstName);
        bool CreateClient(String lastName, String firstName);
        bool CreateGameToTest(String name);
        bool AssignClientToGameToTest(int gameToTestID, int clientID);
        bool AssignSupervisorToGameToTest(int gameToTestID, int employeeID);
        bool AddEmployeeToGameToTest(String lastName, String firstName, String name);
        Employee FindEmployee(String lastName, String firstName);
        GameToTest FindGameToTest(String name);
    }
}
