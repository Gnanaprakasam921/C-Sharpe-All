using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro
{
    public class CustomList<Type>:IEnumerator,IEnumerable
    {
        
       private int _count;
       private int _capacity;
       public int Count { get{return _count;} }
       public int Capacity { get{return _capacity;}  }

       private Type[] _array;

       public CustomList()
       {
        _count=0;
        _capacity=4;
        _array=new Type[_capacity];
       }
       public CustomList(int size)
       {
        _count=0;
        _capacity=size;
        _array=new Type[_capacity];
       }

       public void Add(Type element)
       {
        if(_count==_capacity)
        {
            GrowSize();

        }
        _array[_count]=element;
        _count++;

       }
       void GrowSize()
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

       public void AddRange(CustomList<Type> element)
       {
        Type[] temp= new Type[_capacity];
        for(int i=0;i<_count;i++)
        {
            temp[i]=_array[i];
        }
        int k=0;
        for(int i=_count;i<_count+element.Count;_count++)
        {
            temp[i]=element[k];
            k++;
        }
        _array=temp;
        _count=_count+element.Count;
       }

       public bool Contain(Type element)
       {
        bool temp=false;
        foreach(Type data in _array)
        {
            if(data.Equals(element))
            {
                temp=true;
              break;
            }
            
        }
        return (temp);
       }

       public int IndexOf(Type element)
       {
        int index=-1;
        for(int i=0;i<_count;i++)
        {
            if(element.Equals(_array[i]))
            {
                index=i;
                break;
            }

        }
        return index;
       }

       public void Insert(Type element, int postion)
       {
        _capacity=_capacity+4+1;
        Type[] temp=new Type[_capacity];
        for(int i=0;i<_count+1;i++)
        {
            if(i<postion)
            {
                temp[i]=_array[i];
            }
            else if(i==postion)
            {
                temp[i]=element;

            }
            else 
            {
                temp[i]=_array[i-1];
            }
        }
        _count++;
        _array=temp;
       }

       public void RemoveAt(int postion)
       {
        for(int i=0;i<_count+1;i++)
        {
            if(i>=postion)
            {
                _array[i]=_array[i+1];
            }
        }
        _count--;

       }

       public bool Remove(Type elemnt)
       {
        int postion=IndexOf(elemnt);
        if(postion>=0)
        {
            RemoveAt(postion);
            return true;
        }
        return false;
       }

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