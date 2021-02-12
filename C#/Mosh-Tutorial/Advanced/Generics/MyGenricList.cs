using System;
using System.Collections;
using System.Collections.Generic;

namespace Generics
{
    public class MyGenricList<T> : IEnumerable
    {

        T[] array = new T[3];

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public IEnumerator GetEnumerator()
        {
            foreach ( T item in array)
            {
                yield return item;
            }
        }


    }
}