using System;
using System.Collections.Generic;
using System.Text;
using TwistirrerContract.Models.Tweet;

namespace TwistirrerContract.Models.TimeLine
{
    public interface ITsTimeLine
    {
        /// <summary>
        /// 取得したままのタイムライン
        /// </summary>
        IEnumerable<ITsTweet> BasedTimeLine { get; }

        /// <summary>
        /// フィルター処理を適用したタイムライン
        /// </summary>
        ITsTweet FiltedTimeLine { get; } 
    }
}
