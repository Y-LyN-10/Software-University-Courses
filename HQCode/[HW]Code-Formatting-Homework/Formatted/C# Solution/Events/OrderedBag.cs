﻿namespace Event
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    class OrderedBag<T> : ICollection<T>
    {
        public int Count { get; private set; }

        public bool IsReadOnly { get; private set; }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        internal OrderedBag<Event> RangeFrom(Event p1, bool p2)
        {
            throw new NotImplementedException();
        }
    }
}
