using System.Collections.Generic;
using System.Linq;

namespace RestProject
{
    static class Storage
    {
        internal static IDictionary<string, object> Data { get; set; }

        internal static bool IsCreated => Data != null;

        internal static IDictionary<string, object> Get() => Data?.Select(x => x)?.ToDictionary(x => x.Key, x => x.Value);

        internal static void Set(IDictionary<string, object> newDict)
        {
            Data = newDict;
        }

        internal static void Update(IDictionary<string, object> newParameters)
        {
            foreach (var el in newParameters)
            {
                Data[el.Key] = el.Value;
            }
        }
    }
}
