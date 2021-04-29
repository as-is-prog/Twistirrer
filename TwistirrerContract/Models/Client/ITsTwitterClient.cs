using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TwistirrerContract.Models.TimeLine;
using TwistirrerContract.Models.Tweet;
using TwistirrerContract.Models.User;

namespace TwistirrerContract.Models.Client
{
    public interface ITsTwitterClient
    {
        IEnumerable<ITsAuthUser> Accounts { get; }

        /// <summary>
        /// ログインを行い、認証情報を取得します。
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<ITsAuthUser> LoginAsync(string userid, string password);

        Task<ITsTweet> DoTweetAsync(ITsAuthUser account, string text);

        Task<ITsTimeLine> FetchMainTimeLineAsync(ITsAuthUser account);

        Task<ITsTimeLine> SearchByWordAsync(ITsAuthUser account, string word);
    }
}
