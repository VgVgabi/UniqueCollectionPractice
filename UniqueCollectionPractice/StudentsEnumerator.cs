using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;

namespace UniqueCollectionPractice
{
    public class StudentsEnumerator : IEnumerator<User>
    {
        private StudetsList _collection;
        private int curIndex;
        private User curBox;
        public StudentsEnumerator(StudetsList collection)
        {
            _collection = collection;
            curIndex = -1;
            curBox = default(User);
        }
        //
        public bool MoveNext()
        {
            if (++curIndex >= _collection.Count)
            {
                return false;
            }
            else
            {
                curBox = _collection[curIndex];
            }
            return true;
        }
        //
        public void Reset() { curIndex = -1; }

        void IDisposable.Dispose() { }

        public User Current
        {
            get { return curBox; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }
    }
}
