using System;
using VotingApp.Enums;
using VotingApp.Models;
using VotingApp.Repositories;

namespace VotingApp.Repositories
{
    public class VoterRepo
    {
        public static int myIndex = 0;
        private static int count = 1;

        private static Voter[] voters = new Voter[50];

        public void Register(string matricNo, string password)
        {
            var student = Student.GetStudent(matricNo, password);
            if (student != null)
            {
                var voter = new Voter(count, student.FirstName, student.LastName, student.Gender, student.MatricNo, student.Password, student.Level);
                voters[myIndex] = voter;
                System.Console.WriteLine($"You have successfully create an account and Your Voting is {voter.VotingId}.");
                count++;
                myIndex++;
            }
            else
            {
                System.Console.WriteLine("You are not allow to register.");
            }
        }
        public Voter Login(string matricNo, string password)
        {
            for (int i = 0; i < (myIndex); i++)
            {
                if (voters[i] != null && voters[i].MatricNo == matricNo && voters[i].Password == password)
                {
                    return voters[i];
                }
            }
            return null;
        }
        public static Voter GetVoter(string matricNo, string password)
        {
            for (int i = 0; i < (myIndex); i++)
            {
                if (voters[i] != null && voters[i].MatricNo == matricNo && voters[i].Password == password)
                {
                    return voters[i];
                }
            }
            return null;

        }

    }
}