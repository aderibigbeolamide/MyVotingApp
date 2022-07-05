using System;
using VotingApp.Models;

namespace VotingApp.Models
{
    public class Position
    {
        public int Id { get; set; }
        public int ElectionId { get; set; }
        public string PositionName { get; set; }

        public Position(int id, int electionId, string positionName)
        {
            Id = id;
            ElectionId = electionId;
            PositionName = positionName;
        }
        // public static Position[] positions = new Position[]
        // {
        //     new Position(1, '1', "President"),
        //     new Position(2, '1', "Speaker"),
        //     new Position(3, '1', "Governor"),
        //     new Position(4, '1', "Faculty President"),
        // };
    }
}