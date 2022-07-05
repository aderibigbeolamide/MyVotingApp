using System;
using VotingApp.Enums;
using VotingApp.Models;
using VotingApp.Repositories;

namespace VotingApp.Menu
{
    public class ElectoralOfficerMenu
    {
        ElectoralOfficerRepo electoralOfficerRepo = new ElectoralOfficerRepo();
        ElectionRepo electionRepo = new ElectionRepo();
        ContestantRepo contestantRepo = new ContestantRepo();

        //    Staff staff = new Staff();
        //MainMenu mainMenu = new MainMenu();
        // public ElectoralOfficerMenu()
        // {

        // }
        public void ElectoralOfficerOption()
        {
            System.Console.WriteLine("====================================================");
            System.Console.WriteLine("====================================================");
            System.Console.WriteLine("====================================================");
            System.Console.WriteLine("<<<<<<Welcome to our Electoral Officer Page>>>>>>>>>");
            System.Console.WriteLine("====================================================");
            System.Console.WriteLine("====================================================");
            System.Console.WriteLine("====================================================");
            System.Console.WriteLine("Enter 1 to Log-In.\n Enter 0 to go back to Welcome Page.");
            bool exit = false;
            while (!exit)
            {
                int option;
                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    System.Console.Write("Invalid Input, Enter 1 or 0: ");
                }
                switch (option)
                {
                    case 0:
                        MainMenu.WelcomePage();
                        break;
                    case 1:
                        Login();
                        break;
                    default:
                        System.Console.WriteLine("Invalid Input ");
                        return;
                }
            }
        }
        public void Login()
        {
            System.Console.Write("Enter Your Email: ");
            string email = Console.ReadLine();
            System.Console.WriteLine("Enter Your Password: ");
            string password = Console.ReadLine();
            electoralOfficerRepo.Login(email, password);
            var staffObject = ElectoralOfficerRepo.GetElectoralOfficer(email, password);
            if (staffObject != null && staffObject.Role == Role.ElectoralOfficer)
            {
                PrintSubMenu();
            }
            else if (staffObject != null)
            {
                System.Console.WriteLine("Invalid UserName or Password.");
            }

        }
        public void PrintSubMenu()
        {
            System.Console.WriteLine("Enter 1 to Add New Electoral Committee.\n Enter 2 to Creat New Election.\n Enter 3 to View All vote.\n Enter 0 to go back to Welcome Page.");
            bool exit = false;
            while (!exit)
            {
                int option;
                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    System.Console.Write("Invalid Input, Enter 1, 2, 3 0r 0: ");
                }
                switch (option)
                {
                    case 0:
                        MainMenu.WelcomePage();
                        break;
                    case 1:
                        AddNewElectoralCommittee();
                        PrintSubMenu();
                        break;
                    case 2:
                        CreatNewElection();
                        PrintSubMenu();
                        break;
                    case 3:
                        PrintAllVote();
                        PrintSubMenu();
                        break;
                    default:
                        System.Console.WriteLine("Invalid Input ");
                        return;
                }
            }
        }
        public void AddNewElectoralCommittee()
        {
            System.Console.Write("Enter Staff First Name: ");
            string firstName = Console.ReadLine();
            System.Console.WriteLine("Enter Staff Last Name: ");
            string lastName = Console.ReadLine();
            System.Console.WriteLine("Enter Staff Email: ");
            string email = Console.ReadLine();
            System.Console.WriteLine("Enter Staff Password: ");
            string password = Console.ReadLine();
            System.Console.WriteLine("Enter Staff Gender ()1 - Male, 2 - Female, 3 - RatherNotSay");
            int gender;
            while (!int.TryParse(Console.ReadLine(), out gender))
            {
                System.Console.WriteLine("Invalid input; Enter 1, 2 or 3");
            }
            System.Console.WriteLine("Enter Staff Date Of Birth(yyyy-mm-dd)");
            DateTime dob;
            while (!DateTime.TryParse(Console.ReadLine(), out dob))
            {
                System.Console.WriteLine("Invalid input; Enter Staff Date of Birth");
            }
            System.Console.WriteLine("Enter Staff Address: ");
            string address = Console.ReadLine();
            System.Console.WriteLine("Enter Staff Phone Number");
            string phoneNumber = Console.ReadLine();
            System.Console.WriteLine("Enter Staff Next Of Kin");
            string nextOfKin = Console.ReadLine();
            System.Console.WriteLine("Enter Staff Role ()2 - ElectoralCommittee1, 3 - ElectoralCommittee, 4 - ElectoralCommittee");
            int role;
            while (!int.TryParse(Console.ReadLine(), out role))
            {
                System.Console.WriteLine("Invalid input; Enter; Enter Staff Role ()2 - ElectoralCommittee1, 3 - ElectoralCommittee, 4 - ElectoralCommittee");
            }

            electoralOfficerRepo.AddNewElectoralCommittee(firstName, lastName, email, (Gender)gender, dob, address, phoneNumber, password, (Role)role);
        }
        public void CreatNewElection()
        {
            System.Console.WriteLine("Enter Election name: ");
            string electionName = Console.ReadLine();
            System.Console.WriteLine("Enter Your Election Start Date(yyyy-mm-dd): ");
            DateTime electionStartDate;
            while (!DateTime.TryParse(Console.ReadLine(), out electionStartDate))
            {
                System.Console.WriteLine("Invalid input; Enter Your Election Start Date(yyyy-mm-dd): ");
            }
            System.Console.WriteLine("Enter Your Election End Date(yyyy-mm-dd): ");
            DateTime electionEndDate;
            while (!DateTime.TryParse(Console.ReadLine(), out electionEndDate))
            {
                System.Console.WriteLine("Invalid input; Enter Your Election End Date(yyyy-mm-dd): ");
            }
            electionRepo.CreatElection(electionName, electionStartDate, electionEndDate);
        }
        public void PrintAllVote()
        {
            contestantRepo.ViewAllContestantVotes();
        }
    }
}