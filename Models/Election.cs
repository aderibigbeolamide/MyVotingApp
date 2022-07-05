using System;

namespace VotingApp.Models
{
    public class Election
    {
        public int Id {get; set;}
        public string ElectionName {get; set; }
        public DateTime ElectionStartDate {get; set;}
        public DateTime ElectionEndDate {get; set; }
        public string ElectionId {get; set; }

        public Election(int id, string electionName, DateTime electionStartDate, DateTime electionEndDate)
        {
            Id = id;
            ElectionId = "1"; //$"{Guid.NewGuid().ToString().Replace("-", "").Substring(0, 6). ToUpper()}";
            ElectionName = electionName;
            ElectionStartDate = electionStartDate;
            ElectionEndDate = electionEndDate;
        }
    }
}