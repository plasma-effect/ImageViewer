using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageViewer
{
    static class Utility
    {
        public static IEnumerable<(T, int)> Indexed<T>(this IEnumerable<T> ts)
        {
            var index = 0;
            foreach (var v in ts)
            {
                yield return (v, index++);
            }
        }
    }
}
