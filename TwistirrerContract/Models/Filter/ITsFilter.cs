using System;

namespace TwistirrerContract.Models.Filter
{
    public interface ITsFilter<FilterParam> where FilterParam : ITsFilterParam
    {
        Func<FilterParam, bool> FilterFunc { get; }
    }
}
