using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        public T[] customlist;

        public CustomList()
        {
            customlist = new T[0];
        }

        //public T this[int index]
        //{
        //    return index;
        //}

        //public int GetIndex(int index)
        //{
        //    return index;
        //}

    public void AddToList(T value)
        {
            //customlist + value;
        }

        public void RemoveFromList(T value)
        {

        }

        public void IterateList()
        {

        }

        public void OverrideToString()
        {

        }

        public void OverloadAdd()
        {

        }

        public void OverloadRemove()
        {

        }

        public void CountElementsInList()
        {

        }

        public void ZipThroughList()
        {

        }

    }
}
