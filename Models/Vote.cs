using System;
using VotingApp.Repositories;
using VotingApp.Models;
using VotingApp.Menu;
using VotingApp.Enums;

namespace VotingApp.Models
{
    public class Vote 
    {
        public int Id {get; set; }
        public string VoterId {get; set; }
        public string ElectionId {get; set; }
        public string PositionId {get; set; }
        public string ContestantId {get; set; }

        public Vote(int id, string voterId, string electionId, string positionId, string contestantId)
        {
            Id = id;
            VoterId = voterId;
            ElectionId = electionId;
            PositionId = positionId;
            ContestantId = contestantId;
        }
    }
}