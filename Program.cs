using System;
using System.Collections.Generic;

namespace GameTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            IGamesToTestDB gamesToTestDB = new GamesToTestDB();
            gamesToTestDB.CreateGameToTest("Solstice");
            gamesToTestDB.CreateEmployee("Obando", "Rodrigo");
            gamesToTestDB.CreateEmployee("Falls", "Caleb");
            gamesToTestDB.CreateClient("Mills", "Maria");
            Console.WriteLine(gamesToTestDB.EmployeeList);
            Console.WriteLine("The id of Caleb Falls is " + gamesToTestDB.FindEmployee("Falls", "Caleb"));
        }
    }
}
