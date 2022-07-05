using System;
using VotingApp.Enums;
using VotingApp.Models;
using VotingApp.Repositories;

namespace VotingApp.Models
{
    public class Contestant : Person
    {
        public string ContestantDepartment { get; set; }
        public decimal Grade { get; set; }
        public string PositionName { get; set; }
        public string PositionId { get; set; }

        public string ContestantId { get; set; }

        public int VoteCount { get; set; }
        public int GetAllVote { get; set; }


        public Contestant(int id, string firstName, string lastName, Gender gender, string matricNo, string password, string contestantDepartment, Level level, decimal grade) : base(id, firstName, lastName, gender, matricNo, password, level)
        {
            PositionId = "1";//$"{Guid.NewGuid().ToString().Replace("-", "").Substring(0, 5).ToUpper()}";
            ContestantId = "1";//$"{Guid.NewGuid().ToString().Replace("-", "").Substring(0, 6).ToUpper()}";
            ContestantDepartment = contestantDepartment;
            Grade = grade;
            // PositionName = positionName;
        }

        public static Contestant[] contestants = new Contestant[]
        {
            new Contestant(1, "Ade", "ola", Gender.Male, "clh/01/2022", "ola", "Faculty of Science", Level.Year1, 3.7m),
            new Contestant(2, "Idris", "olobe", Gender.Male, "clh/02/2022", "idris", "Faculty Art", Level.Year2, 3.8m),
            new Contestant(3, "Aderibigbe", "musodiq", Gender.Male, "clh/03/2022", "aderibigbe", "Faculty Science", Level.Year6, 4.0m),
            new Contestant(4, "Hamzat", "yomi", Gender.Male, "clh/04/2022", "ola", "Faculty of Science", Level.Year1, 3.5m),
            new Contestant(5, "Eba", "oriyomi", Gender.Female, "clh/05/2022", "eba", "Faculty of Law", Level.Year3, 3.7m),
        };
        public static Contestant GetContestant(string matricNo, string password)
        {
            foreach (var contest in contestants)
            {
                if (contest.MatricNo == matricNo && contest.Password == password)
                {
                    return contest;
                }
            }
            return null;
        }
    }

}
