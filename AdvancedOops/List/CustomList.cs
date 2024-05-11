using System;
using System.Collections.Generic;

namespace List
{
    public partial class CustomList<Type>   // type is is user defind data type, we create multiple eg:<Type1, Type2,...>

    {
        //filed
        // we crate private filed 1. _count 2. _capacity.
        private int _count;
        private int _capacity;

        //create property for field. create Readonly Property
        public int Count { get { return _count; } }
        public int Capacity { get { return _capacity; } }

        // array creation
        private Type[] _array;


      
        //create Constructor
        public CustomList()
        {
            _count = 0;   // initial count=0
            _capacity = 4;   // capatitity we assain =4
            _array = new Type[_capacity];  // capacity to assign for array
        }

        //create Perameterized constructor:
        public CustomList(int size)
        {
            _count = 0;
            _capacity = size;
            _array = new Type[_capacity];
        }

        // method
        public void Add(Type element)
        {
            //check the count and capacity if(4==4) grow the list
            if (_count == _capacity)
            {
                GrowSize();
            }
            // add the element to the array form program.cs add list.
            _array[_count] = element;
            _count++;

        }
        // grow the List size 
        void GrowSize()
        {
            _capacity = _capacity * 2;

            // create a temprory array for store the growsize 
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < _count; i++)
            {
                // assign the old array element to the new array element
                temp[i] = _array[i];
            }
            // assign the new array to old array
            _array = temp;
        }

          // indexer using in AddRange()
        public Type this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }

        public void AddRange(CustomList<Type> elements) // here elemennts is a object  // We d
        {
            _capacity = _count + elements.Count + 4;// for extra add for 4 reduce the time to grow size.
            // same as add create a new array
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < _count; i++)
            {
                // assign array to temp
                temp[i] = _array[i];
            }
            int k = 0;
            for (int i = _count; i < _count + elements.Count; i++) // for(10;10+3;i++)
            {
                temp[i] = elements[k];       // When we cosider object to element we create Indexer
                k++;
            }
            // Assign temp to array
            _array = temp;
            // increse the count value 
            _count = _count + elements.Count;
        }
        // Contain method like using string
        // used for check wheather return ture or false
        public bool Contain(Type element)
        {
            bool temp = false;
            foreach (Type data in _array)
            {
                //can't used assingment operator like ==,>,<. use .Equals.
                if (data.Equals(element))
                {
                    temp = true;
                    break;
                }
            }
            return (temp);
        }

        public int IndexOf(Type element)
        {
            int index = -1;
            for (int i = 0; i < _count; i++)
            {
                if (element.Equals(_array[i]))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        // insert method
        // insert 6 in 2nd inded  
        // 1 2 3 4 5
        // 1 2 6  3 4 5 
        public void Insert(int position, Type element)
        {
            _capacity = _capacity + 1 + 4; // we add extra 4 , +1 means next index
           // create new array
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < _count + 1; i++)
            {
                if (i < position)
                {
                    temp[i] = _array[i];
                }
                else if (i == position)
                {
                    temp[i] = element;

                }
                else
                {
                    temp[i] = _array[i - 1];
                }
            }
            _count++;
            _array = temp;
        }

        // remove method using removeAt
        // 1 2 3 4 5
        // 1 2 4 5

        public void removeAt(int position)
        {
            for (int i = 0; i < _count-1; i++)
            {
                if (i >= position)
                {
                    _array[i] = _array[i + 1];

                }
            }
            _count--;

        }
        public bool Remove(Type element)
        {
            int position = IndexOf(element);
            if (position >= 0)
            {
                removeAt(position);
                return true;
            }
            return false;
        }

        public void Reverse()
        {
            Type[] temp = new Type[_capacity];
            int j = 0;
            for (int i = _count - 1; i >= 0; i--)
            {
                temp[j] = _array[i];
            }
            _array = temp;
        }
        // inser element 7,6,8
        // inser range=2
        // normal 1,2,3,4,5
        //AFTER 1,2,7,6,8,3,4,5
        public void InsertRange(int position, CustomList<Type> element)
        {
            _capacity = Count + element.Count + 4;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < position; i++)
            {
                temp[i] = _array[i];
            }
            int j = 0;
            for (int i = position; i < position + element.Count; i++)
            {
                temp[i] = element[j];
                j++;

            }
            int k = position;
            for (int i = position + element.Count; i < _count + element.Count; i++)
            {
                temp[i] = _array[k];
                k++;
            }
            _array = temp;
            _count = _count + element.Count;
        }
        public void Sort()
        {
            for (int i = 0; i < _count-1; i++)
            {
                for (int j = 0; j < _count-1; j++)
                {
                    // not use _arrary[i]>_arraru[i+1]  use create difffernt method(Isgreater)
                    Type temp=_array[j+1];
                    _array[j+1]=_array[j];
                    _array[j]=temp;
                    
                    }
            }
        }
        public bool IsGreater( Type value, Type value1)
        {
            int result=Comparer<Type>.Default.Compare(value,value1);
            if(result>0)
            {
                return true;

            }
            return false;
        }
        


    }


}













// public class customList<Type>
// {
//     private int _count;
//     private int _capacity;

//     public int Count{get {return _count;}}
//     public int Capaicty{get {return _capacity;}}

//     private Type[] _array;

//     public
// }
