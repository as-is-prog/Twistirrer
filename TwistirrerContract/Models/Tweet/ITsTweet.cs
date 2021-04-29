using System;
using System.Collections.Generic;
using System.Text;
using TwistirrerContract.Models.User;

namespace TwistirrerContract.Models.Tweet
{
    public interface ITsTweet
    {
        ITsUser Author { get; }

        string Text { get; }
    }
}
