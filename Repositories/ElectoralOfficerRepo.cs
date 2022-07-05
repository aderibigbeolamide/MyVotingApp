using System;
using VotingApp.Enums;
using VotingApp.Models;
using VotingApp.Repositories;

namespace VotingApp.Repositories
{
    public class ElectoralOfficerRepo
    {
        private static int count = 2;
        private readonly Contestant contestant;
        public static ElectoralOfficer[] electoralOfficers = new ElectoralOfficer[50];
        private static int myIndex = 1;
        public ElectoralOfficerRepo()
        {
            var electoralOfficer = new ElectoralOfficer(1, "Boss", "Oga", "boss@gmail.com", Gender.RatherNotSay,
            DateTime.Parse("1960-07-20"), "abk", "08012345678", "password", Role.ElectoralOfficer);
            electoralOfficers[0] = electoralOfficer;
        }
        public void AddNewElectoralCommittee(string firstName, string lastName, string email, Gender gender,
        DateTime dob, string address, string phoneNumber, string password, Role role)
        {
            ElectoralOfficer electoralOfficer = new ElectoralOfficer(count, firstName, lastName, email, gender, dob, address, phoneNumber, password, role);
            electoralOfficers[myIndex] = electoralOfficer;
            System.Console.WriteLine("New Staff created successfully.....");
            count++;
            myIndex++;
        }
        public ElectoralOfficer Login(string email, string password)
        {
            var electoralOfficer = GetElectoralOfficer(email, password);
            if (electoralOfficer != null && electoralOfficer.Password == password)
            {
                return electoralOfficer;
            }
            return null;
        }
        public static ElectoralOfficer GetElectoralOfficer(string email, string password)
        {
            for (int i = 0; i < (myIndex); i++)
            {
                if (((electoralOfficers[i] != null) && electoralOfficers[i].Email == email) && (electoralOfficers[i] != null) && electoralOfficers[i].Password == password)
                {
                    return electoralOfficers[i];
                }
            }
            return null;
        }
    }
}