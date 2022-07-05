using System;
using VotingApp.Enums;
using VotingApp.Models;
using VotingApp.Repositories;

namespace VotingApp.Repositories
{
    public class ContestantRepo
    {
        private readonly ElectionRepo electionRepo;
        private readonly Election election;
        public static int myIndex = 0;
        private static int count = 1;
        private decimal grade = 3.5m;
        //private static int VoteCount = 0;
        public static Contestant[] contestants = new Contestant[10];

        public void Register(string matricNo, string password)
        {
            var contest = Contestant.GetContestant(matricNo, password);
            if (contest != null)
            {
                var contestant = new Contestant(count, contest.FirstName, contest.LastName, contest.Gender, contest.MatricNo, contest.Password, contest.ContestantDepartment, contest.Level, contest.Grade);
                contestants[myIndex] = contestant;
                System.Console.WriteLine($"You have successfully create an account");
                System.Console.WriteLine($"Election created successsfully and Your Position ID is {contestant.PositionId}");
                System.Console.WriteLine($"Election created successsfully and Your Contestant ID is {contestant.ContestantId}");
                count++;
                myIndex++;
            }
            else
            {
                System.Console.WriteLine("You are not allow to register.");
            }
        }
        public Contestant Login(string matricNo, string password)
        {
            for (int i = 0; i < (myIndex); i++)
            {
                if (contestants[i] != null && contestants[i].MatricNo == matricNo && contestants[i].Password == password)
                {
                    return contestants[i];
                }
            }
            return null;
        }
        public Contestant GetContestant(string matricNo, string password)
        {
            for (int i = 0; i < (myIndex); i++)
            {
                if (contestants[i] != null && contestants[i].MatricNo == matricNo && contestants[i].Password == password)
                {
                    return contestants[i];
                }
            }
            return null;
        }


        public Contestant GetContestant(string matricNo)
        {
            for (int i = 0; i < (myIndex); i++)
            {
                if (contestants[i] != null && contestants[i].MatricNo == matricNo)
                {
                    return contestants[i];
                }
            }
            return null;
        }

        public bool Getgrade(decimal grade)
        {
            if (grade >= 3.5m)
            {
                return true;
            }
            return false;
        }

        public void VoteCount(Contestant contestant)
        {
            System.Console.WriteLine($"Your vote Record is: {contestant.VoteCount}");
        }
        public void ViewAllContestantVotes()
        {
            if(contestants!=null)
            {
                System.Console.WriteLine("The result of All Candidate are.");
                foreach (var contestant  in contestants)
                {

                    Console.WriteLine($"The Matric Number of the Contestant is {contestant.MatricNo} and his vote count is {contestant.VoteCount}");
                }

            }
            Console.WriteLine("Data Not Found");   
        }
        // Comment
    }
}