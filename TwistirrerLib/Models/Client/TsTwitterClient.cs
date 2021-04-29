using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TwistirrerContract.Models.Client;
using TwistirrerContract.Models.TimeLine;
using TwistirrerContract.Models.Tweet;
using TwistirrerContract.Models.User;

namespace TwistirrerLib.Models.Client
{
    public class TsTwitterClient : ITsTwitterClient
    {
        public IEnumerable<ITsAuthUser> Accounts => throw new NotImplementedException();

        public Task<ITsTweet> DoTweetAsync(ITsAuthUser account, string text)
        {
            throw new NotImplementedException();
        }

        public Task<ITsTimeLine> FetchMainTimeLineAsync(ITsAuthUser account)
        {
            throw new NotImplementedException();
        }

        public Task<ITsAuthUser> LoginAsync(string userid, string password)
        {
            throw new NotImplementedException();
        }

        public Task<ITsTimeLine> SearchByWordAsync(ITsAuthUser account, string word)
        {
            throw new NotImplementedException();
        }
    }
}
