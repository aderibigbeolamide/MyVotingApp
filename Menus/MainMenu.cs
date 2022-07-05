using System;
using VotingApp.Enums;
using VotingApp.Repositories;
using VotingApp.Models;

namespace VotingApp.Menu
{
    public class MainMenu
    {
        static ContestantMenu contestantMenu = new ContestantMenu();
        static ElectoralOfficerMenu electoralOfficerMenu = new ElectoralOfficerMenu();
        static VoterMenu voterMenu = new VoterMenu();

        public VoterRepo voterRepo;
        public ContestantRepo contestantRepo;
        public ElectoralOfficerRepo electoralOfficerRepo;

        public MainMenu()
        {
            contestantRepo = new ContestantRepo();
            electoralOfficerRepo = new ElectoralOfficerRepo();
            voterRepo = new VoterRepo();
        }
        public static void WelcomePage()
        {
            System.Console.WriteLine("=============================================");
            System.Console.WriteLine("=============================================");
            System.Console.WriteLine("=============================================");
            System.Console.WriteLine("<<<<<<Welcome to our Voting App Page>>>>>>>>>");
            System.Console.WriteLine("=============================================");
            System.Console.WriteLine("=============================================");
            System.Console.WriteLine("=============================================");
            System.Console.WriteLine("Enter 1 to Contestant Menu.\nEnter 2 to Electoral Officer Menu.\n Enter 3 to Voter's Menu.");
            bool exit = false;
            while (!exit)
            {
                int option;
                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    System.Console.Write("Invalid Input, Enter 1 or 2: ");
                }
                switch (option)
                {
                    case 1:
                        contestantMenu.ContestantOption();
                        break;
                    case 2:
                        electoralOfficerMenu.ElectoralOfficerOption();
                        break;
                    case 3:
                        voterMenu.VoterOption();
                        break;
                    default:
                        System.Console.WriteLine("Invalid Input ");
                        exit = true;
                        return;
                }
            }
        }
    }


}