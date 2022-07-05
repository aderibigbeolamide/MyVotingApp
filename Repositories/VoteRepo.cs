using System;
using System.Text;
using System.Linq;
using VotingApp.Models;
using VotingApp.Enums;
using VotingApp.Repositories;

namespace VotingApp.Repositories
{
    public class VoteRepo
    {
        public static int myIndex = 0;
        private static int count = 1;
        private readonly ContestantRepo contestantRepo;
        private readonly ElectionRepo electionRepo;
        private readonly PositionRepo positionRepo;
        private readonly VoterRepo voterRepo;
        public static Vote[] votes = new Vote[100];

        public VoteRepo()
        {
            var vote = new Vote(1, "1", "1", "1", "1");
            votes[0] = vote;
        }
        public VoteRepo(ContestantRepo _contestantRepo, ElectionRepo _electionRepo, PositionRepo _positionRepo, VoterRepo _voterRepo, VoteRepo _voteRepo)
        {

            contestantRepo = _contestantRepo;
            electionRepo = _electionRepo;
            positionRepo = _positionRepo;
            voterRepo = _voterRepo;
            voterRepo = _voterRepo;
        }
        public void CastVote(string voteId, string electionId, string positionId, string contestantId, Contestant contestant)
        { 
            if (CheckContestantId(contestantId) == true)
            {
                System.Console.WriteLine("You have already voted for this candidate.");
            }
            else
            {
                var vote = new Vote(count, voteId, electionId, positionId, contestantId);
                votes[myIndex] = vote;
                System.Console.WriteLine($"Your Vote has been cast successsfully.....");
                contestant.VoteCount++;
                count++;
                myIndex++;
            }

        }
        public bool CheckContestantId(string contestantId)
        {
            for (int i = 0; i < (myIndex); i++)
            {
                if (votes[i] != null && votes[i].ContestantId == contestantId)
                {
                    return true;
                }
            }
            return false;
        }

    }

}