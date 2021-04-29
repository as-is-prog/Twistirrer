using System;
using System.Collections.Generic;
using System.Text;
using TwistirrerContract.Models.Client;
using TwistirrerLib.Models.Client;

namespace TwistirrerLib.Models.Resolver
{
    public static class TsTwitterClientResolver
    {
        public static ITsTwitterClient Resolve()
        {
            return new TsTwitterClient();
        }
    }
}
