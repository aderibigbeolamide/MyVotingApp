using System;
using VotingApp.Enums;
using VotingApp.Models;

namespace VotingApp.Models
{
    public class Voter : Person
    {
        public string VotingId {get; set; }

        public Voter(int id, string firstName, string lastName, Gender gender, string matricNo,  
        string password, Level level): base(id, firstName, lastName, gender, matricNo, password, level)
        {
            VotingId = "1";//$"{Guid.NewGuid().ToString().Replace("-", "").Substring(0, 12).ToUpper()}";
        }
    }
    
}