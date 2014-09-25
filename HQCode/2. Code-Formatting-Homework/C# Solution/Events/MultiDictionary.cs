using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Event
{
    class MultiDictionary<T1, T2> : Dictionary<T1,T2>, ICollection<T1>
    {
        public new IEnumerator<T1> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T1 item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T1 item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T1[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T1 item)
        {
            throw new NotImplementedException();
        }

        public int Count { get; private set; }
        public bool IsReadOnly { get; private set; }
    }
}
