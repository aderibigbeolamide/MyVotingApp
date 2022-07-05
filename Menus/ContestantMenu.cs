using System;
using VotingApp.Enums;
using VotingApp.Models;
using VotingApp.Repositories;

namespace VotingApp.Menu
{
    public class ContestantMenu
    {

        ContestantRepo contestantRepo = new ContestantRepo();
        PositionRepo positionRepo = new PositionRepo();
        Contestant contestant;

        // MainMenu mainMenu = new MainMenu();
        // public CustomerMenu()
        // {

        // }
        public void ContestantOption()
        {
            System.Console.WriteLine("=============================================");
            System.Console.WriteLine("=============================================");
            System.Console.WriteLine("=============================================");
            System.Console.WriteLine("<<<<<<Welcome to our Contestant Page>>>>>>>>>");
            System.Console.WriteLine("=============================================");
            System.Console.WriteLine("=============================================");
            System.Console.WriteLine("=============================================");
            System.Console.WriteLine("Enter 1 to Log-In.\tEnter 2 to Sign-Up.\n Enter 0 to go back to Welcome Page");
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
                        ContestantOption();
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
            var userObject = contestantRepo.Login(matricNo, password);
            if (userObject != null && userObject.Password == password)
            {
                PrintOtherMenu(userObject);
            }
            else if (userObject == null)
            {
                System.Console.WriteLine("Invalid UserName or Password.");
            }
        }
        public void PrintOtherMenu(Contestant contestant)
        {
            System.Console.WriteLine("Enter 1 to View All Position.\n Enter 2 to View Your Result.\n Enter 0 to go back to Welcome Page.");
            bool exit = false;
            while (!exit)
            {
                int option;
                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    System.Console.Write("Invalid Input, Enter 1, 2 or 0: ");
                }
                switch (option)
                {
                    case 0:
                        MainMenu.WelcomePage();
                        break;
                    case 1:
                        ViewPosition();
                        PrintOtherMenu(contestant);
                        break;
                    case 2:
                        contestantRepo.VoteCount(contestant);
                        PrintOtherMenu(contestant);
                        return;
                    default:
                        System.Console.WriteLine("Invalid Input: ");
                        return;
                }
            }
        }
        public void ViewPosition()
        {
            System.Console.WriteLine("Enter ElectionId: ");
            int electionId;
            while (!int.TryParse(Console.ReadLine(), out electionId))
            {
                System.Console.Write("Invalid Input, Enter 1, 2 or 0: ");
            }
            System.Console.WriteLine("Enter Position Name: ");
            string positionName = Console.ReadLine();
            positionRepo.CreatPosition(electionId, positionName);
        }
        // public void ViewPosition()
        // {
        //     positionRepo.GetAllPosition();
        //     System.Console.WriteLine("Choose 1 Position.");
        //     string position = Console.ReadLine();
        //     if (positionRepo.GetPosition(position) != null)
        //     {
        //         contestant.PositionName = position;
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("Invalid Input.");
        //     }
        // }
        // public void VoteCount()
        // {
        //     System.Console.WriteLine("Your vote Record is: ");
        // }

        public void Register()
        {
            // System.Console.Write("Enter Your First Name: ");
            // string firstName = Console.ReadLine();
            // System.Console.WriteLine("Enter Your Last Name: ");
            // string lastName = Console.ReadLine();
            // System.Console.WriteLine("Enter Your Email: ");
            // System.Console.WriteLine("Enter Your Gender ()1 - Male, 2 - Female, 3 - RatherNotSay");
            // int gender = int.Parse(Console.ReadLine());
            // while (!int.TryParse(Console.ReadLine(), out gender))
            // {
            //     System.Console.WriteLine("Invalid input; Enter 1, 2 or 3");
            // }
            System.Console.WriteLine("Enter Your matricNo: ");
            string matricNo = Console.ReadLine();
            System.Console.WriteLine("Enter Your Password");
            string password = Console.ReadLine();
            // System.Console.WriteLine("Enter Your Level ()1 - Year1, 2 - Year2, 3 - Year3, 4 - Year4, 5 - Year5, 6 - Year6");
            // int level = int.Parse(Console.ReadLine());
            // while (!int.TryParse(Console.ReadLine(), out level))
            // {
            //     System.Console.WriteLine("Invalid input; Enter 1, 2, 3, 4, 5, 6");
            // }
            // System.Console.WriteLine("Enter Your Departmanet");
            // string contestantDepartment = Console.ReadLine();
            // System.Console.WriteLine("Enter Your grade");
            // decimal grade = int.Parse(Console.ReadLine());
            // while (!decimal.TryParse(Console.ReadLine(), out grade))
            // {
            //     System.Console.WriteLine("Invalid input; ");
            // }


            // if (contestantRepo.Getgrade(grade) == false)
            // {
            //     System.Console.WriteLine("You are not eligible for any Position.");
            // }
            // else
            // {
            //     System.Console.WriteLine("Enter Contestant Position Name");
            //     string positionName = Console.ReadLine();
            contestantRepo.Register(matricNo, password);
        }


    }
}
