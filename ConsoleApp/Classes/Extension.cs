using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Classes
{
    static class Extension
    {
        public static void AddUnique<T>(this List<T> list, T obj)
        {
            if (!list.Contains(obj))
            {
                list.Add(obj);
            }
        }

    }
}
