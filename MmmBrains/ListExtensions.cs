using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmmBrains
{
    public static class ListExtensions
    {
        public static List<T> Shuffle<T>(this List<T> list)
        {
            return list.OrderBy(x => Global.NumberGenerator.Next()).ToList();
        }
    }
}
