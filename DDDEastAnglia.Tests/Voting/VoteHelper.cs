﻿using DDDEastAnglia.DataAccess.EntityFramework.Models;
using DDDEastAnglia.DataModel;

namespace DDDEastAnglia.Tests.Voting
{
    public static class VoteHelper
    {
        public static bool IsVoteFor(this Vote vote, int expectedSessionId)
        {
            if (vote.SessionId != expectedSessionId)
            {
                return false;
            }
            return true;
        }

        public static bool VoteHasBeenRemoved(this Vote vote, int sessionRemoved)
        {
            if (vote.SessionId != sessionRemoved)
            {
                return false;
            }
            return true;
        }

    }
}