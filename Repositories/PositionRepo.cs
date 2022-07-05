using System;
using VotingApp.Models;

namespace VotingApp.Repositories
{
    public class PositionRepo
    {
        public static int myIndex = 0;
        private static int count = 1;
        private decimal grade = 10;
        public static Position[] positions = new Position[]
        {
            new Position(1, '1', "President"),
            new Position(2, '1', "Speaker"),
            new Position(3, '1', "Governor"),
            new Position(4, '1', "Faculty President"),
        };

        public void CreatPosition(int electionId, string positionName)
        {
            if (CheckPositionName(positionName) == true)
            {
                System.Console.WriteLine("This Position is not Available.");
            }
            else
            {
                var position = new Position(count, electionId, positionName);
                positions[myIndex] = position;
                System.Console.WriteLine($"Position created successsfully.....");
                count++;
                myIndex++;
            }
        }
        public Position GetPosition(string positionName)
        {
            for (int i = 0; i < myIndex; i++)
            {
                if (positions[i] != null)
                {
                    return positions[i];
                }
            }
            return null;
        }
        public bool CheckPositionName(string positionName)
        {
            for (int i = 0; i < (myIndex); i++)
            {
                if (positions[i] != null && positions[i].PositionName == positionName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}