using System;
using System.Collections;
using System.Collections.Generic;

namespace MyEnumerable
{
    public class Guarda3<T> : IEnumerable<T>
    {
        private T Var1;
        private T Var2;
        private T Var3;

        public Guarda3()
        {
            Var1 = default;
            Var2 = default;
            Var3 = default;
        }
        public T GetItem(int i)
        {
            if (i < 0 || i > 2) throw new IndexOutOfRangeException();
            else if (i == 0) return Var1;
            else if (i == 1) return Var2;
            else return Var3;
        }

        public void SetItem(int i, T item)
        {
            if (i < 0 || i > 2) throw new IndexOutOfRangeException();
            else if (i == 0) Var1 = item;
            else if (i == 1) Var2 = item;
            else Var3 = item;
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < 3; i++)
                yield return GetItem(i) ;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator ();
        }
    }
}