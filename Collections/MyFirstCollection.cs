using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class MyFirstCollection<T>:IEnumerable<T>
    {
        private T[] items;
        private int count;

        public MyFirstCollection()
        {
            // initial set size of T[]
            items = new T[4];
            count = 0;
        }

        public void Add(T item)
        {
            if (count > items.Length - 1)
            {
                // resize the array
                Array.Resize(ref items, count * 2);

            }

            items[count++] = item;
        }

        public void Clear()
        {
            Array.Clear(items,0, items.Length);
        }

        public T this[int idx]
        {
            get
            {
                return items[idx];
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public void Update(int index,T item)
        {
            items[index] = item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
        }
    }
}
