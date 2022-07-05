using System;
using VotingApp.Models;
using VotingApp.Repositories;

namespace VotingApp.Repositories
{
    public class ElectionRepo
    {
        private readonly ContestantRepo contestantRepo;
        public static int myIndex = 0;
        private static int count = 1;
        private decimal grade = 10;
        public static Election[] elections = new Election[30];


        public void CreatElection(string electionName, DateTime electionStartDate, DateTime electionEndDate)
        {
            var election = new Election(count, electionName, electionStartDate, electionEndDate);
            elections[myIndex] = election;
            System.Console.WriteLine($"Election created successsfully and Your Election ID is {election.ElectionId}");
            count++;
            myIndex++;
        }
        public Election GetElection(string electionName)
        {
            for (int i = 0; i < myIndex; i++)
            {
                if (elections[i] != null)
                {
                    return elections[i];
                }
            }
            return null;
        }
    }
}