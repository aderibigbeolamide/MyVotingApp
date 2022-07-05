using System;
using VotingApp.Enums;
using VotingApp.Models;
using VotingApp.Menu;
using VotingApp.Repositories;

namespace VotingApp.Menu
{
    public class VoterMenu
    {
        VoterRepo voterRepo = new VoterRepo();
        VoteRepo voteRepo = new VoteRepo();
        ElectionRepo electionRepo = new ElectionRepo();
        PositionRepo positionRepo = new PositionRepo();
        ContestantRepo contestantRepo = new ContestantRepo();
        private readonly Person person;
        //MainMenu mainMenu = new MainMenu();
        // public CustomerMenu()
        // {

        // }
        public void VoterOption()
        {
            System.Console.WriteLine("====================================================");
            System.Console.WriteLine("====================================================");
            System.Console.WriteLine("====================================================");
            System.Console.WriteLine("<<<<<<<<Welcome to our Voter's Page>>>>>>>>>>>>>>>>>");
            System.Console.WriteLine("====================================================");
            System.Console.WriteLine("====================================================");
            System.Console.WriteLine("====================================================");
            System.Console.WriteLine("Enter 1 to Log-In.\tEnter 2 to Sign-Up.\n Enter 0 to go back to Welcome Page.");
            bool exit = false;
            while (!exit)
            {
                int option;
                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    System.Console.Write("Invalid Input, Enter 1 , 2 or 0: ");
                }
                switch (option)
                {
                    case 0:
                        MainMenu.WelcomePage();
                        break;
                    case 1:
                        Login();
                        break;
                    case 2:
                        Register();
                        VoterOption();
                        break;
                    default:
                        System.Console.WriteLine("Invalid Input ");
                        return;
                }
            }
        }
        public void Login()
        {
            System.Console.Write("Enter Your Matric Number: ");
            string matricNo = Console.ReadLine();
            System.Console.WriteLine("Enter Your Password: ");
            string password = Console.ReadLine();
            var userObject = voterRepo.Login(matricNo, password);
            if (userObject != null && userObject.Password == password)
            {
                PrintOtherMenu();
            }
            else if (userObject == null)
            {
                System.Console.WriteLine("Invalid UserName or Password.");
            }
        }
        public void PrintOtherMenu()
        {
            System.Console.WriteLine("Enter 1 to Cast Your Vote.\n Enter 0 to go back to Welcome Page.");
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
                        Castvote();
                        PrintOtherMenu();
                        break;
                    default:
                        System.Console.WriteLine("Invalid Input: ");
                        return;
                }
            }
        }
        public void Castvote()
        {
            System.Console.WriteLine("Enter The Voting Id: ");
            string voteId = Console.ReadLine();
            System.Console.WriteLine("Enter The Election Id: ");
            string electionId = Console.ReadLine();
            System.Console.WriteLine("Enter The Position Id: ");
            string positionId = Console.ReadLine();
            System.Console.WriteLine("Enter The Contestant Id: ");
            string contestantId = Console.ReadLine();
            System.Console.WriteLine("Enter The Contestant matricNo: ");
            string matricNo = Console.ReadLine();
            if (matricNo != null)
            {
                System.Console.WriteLine("Cast your vote.");
            }
            else
            {
                System.Console.WriteLine("You have already voted for this candidate.");
            }
            var contes = contestantRepo.GetContestant(matricNo);
            voteRepo.CastVote(voteId, electionId, positionId, contestantId, contes);
        }
        public void Register()
        {
            // System.Console.Write("Enter Your First Name: ");
            // string firstName = Console.ReadLine();
            // System.Console.WriteLine("Enter Your Last Name: ");
            // string lastName = Console.ReadLine();
            // System.Console.WriteLine("Enter Your Email: ");
            // System.Console.WriteLine("Enter Your Gender ()1 - Male, 2 - Female, 3 - RatherNotSay");
            // int gender;
            // while (!int.TryParse(Console.ReadLine(), out gender))
            // {
            //     System.Console.WriteLine("Invalid input; Enter 1, 2 or 3");
            // }
            System.Console.WriteLine("Enter Your matricNo: ");
            string matricNo = Console.ReadLine();
            System.Console.WriteLine("Enter Your Password");
            string password = Console.ReadLine();
            // System.Console.WriteLine("Enter Your Level ()1 - Year1, 2 - Year2, 3 - Year3, 4 - Year4, 5 - Year5, 6 - Year6");
            // int level;
            // while (!int.TryParse(Console.ReadLine(), out level))
            // {
            //     System.Console.WriteLine("Invalid input; Enter 1, 2, 3, 4, 5, 6");
            // }
            voterRepo.Register(matricNo, password);

        }
    }
}