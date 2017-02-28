using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> myList = new CustomList<int>();
            myList.AddToList(16);
            List<int> theirList = new List<int>();
            theirList.Add(16);
        }
    }
}
