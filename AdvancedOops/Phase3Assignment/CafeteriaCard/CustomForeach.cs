using System;
using System.Collections;

namespace CafeteriaCard
{
    public partial class CustomList<Type>:IEnumerable,IEnumerator
    {
        int postion;
        public IEnumerator GetEnumerator()
        {
            postion=-1;
            return (IEnumerator)this;
        }
        public bool MoveNext()
        {
            if(postion<_count-1)
            {
                postion++;
                return true;

            }
            Reset();
            return false;

        }
        public void Reset()
        {
            postion=-1;
        }
        public object Current{get {return _array[postion];}}
    }
}
