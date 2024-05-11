using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace List
{
    public class NewClass<Type>:IEnumerator,IEnumerable

    {
        private int _count;
        private int _capacity;

        public int Count { get {return _count;} }
        public int Capacity { get {return _capacity;} }

        private Type[] _array;

        public NewClass()
        {
            _count=0;
            _capacity=4;
            _array=new Type[_capacity];
        }
        public NewClass(int size)
        {
            _count=0;
            _capacity=size;
            _array=new Type[_capacity];
        }

        public void Add(Type element)
        {
            if(_count==_capacity)
            {
                GorwSize();
            }
            _array[_count]=element;
            _count++;

        }
        void GorwSize()
        {
            _capacity *=2;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;
        }

        public Type this[int index]
        {
            get{return _array[index];}
            set{_array[index]=value;}
        }

        public void AddRange(NewClass<Type> element)
        {
            _capacity=_count+element.Count+4;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            int k=0;
            for(int i=0;i<_count+element.Count;i++)
            {
                temp[i]=element[k];
            }
            k++;
            _count=_count+element.Count;
        }

        // public bool Contain(Type element)
        // {
            
        // }
        int postion;
        public IEnumerator GetEnumerator()
        {
            postion=-1;
            return this;
        }

        public bool MoveNext()
        {
            if(postion<_count)
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

        public  object Current{get{return _array[postion];}}






    }
}