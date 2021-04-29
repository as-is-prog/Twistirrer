using System;
using System.Collections.Generic;
using System.Text;
using TwistirrerContract.Models.Tweet;

namespace TwistirrerContract.Models.TimeLine
{
    public interface ITsMergedTimeLine
    {
        IList<ITsTimeLine> TimeLines { get; }
        
        IEnumerable<ITsTweet> Tweets { get; }
    }
}
