using System;
using System.Collections;

namespace CustomQueue
{
    public class CusQueue<Type>:IEnumerator,IEnumerable
    {
        private int _head;
        private int _tail;
        private int _capacity;
        private int _count;
        public int Count { get{return _count;} }

        private Type[] _array; // create array
        public CusQueue()
        {
            _head=0;
            _tail=0;
            _count=0;
            _capacity=4;
            _array=new Type[_capacity];
        }
        public CusQueue(int size)
        {
            _head=0;
            _tail=0;
            _count=0;
            _capacity=size;
            _array=new Type[_capacity];
        }

        public void Enqueue(Type value)
        {
            if(_capacity==_tail)
            {
                GrowSize();
            }
            _array[_tail]=value;
            _tail++;
            _count++;

        }

        void GrowSize()
        {
            _capacity=2*_capacity;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_tail;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;

        }

        public Type Peek()
        {
            if(_head==_tail)
            {
                return default(Type);
            }
            else{
                return _array[_head];
            }
        }

        public Type Dequeue()
        {
         if(_head==_tail)
            {
                return default(Type);
            }
            else{
                _head++;
                _count--;
                return _array[_head-1];
            }   
            
        }

        // for using foreach:
        int position;
        public IEnumerator GetEnumerator()
        {
            position=_head-1;
            return (IEnumerator)this;
        }

        public bool MoveNext()
        {
            if(position<_tail-1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }
        public void Reset()
        {
            position=_head-1;

        }

        public object Current{get{return _array[position];}}
        
    }
}
