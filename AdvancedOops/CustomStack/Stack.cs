using System;
using System.Collections;

namespace CustomStack
{
    public class Stack<Type>
    {
        private int _capacity;
        private int _top;
        //property
        public int Capacity {get{return _capacity;} }  //Readonly property
        public int Count { get {return _top+1;} }

        // normal intger array   private int[] _array;
        // generic array
        //creating array
        private Type[] _array;

        //constructor
        public Stack()
        {
            _top=-1;  //initial
            _capacity=4;  // initial we assigned
            _array=new Type[_capacity];  // Arrary created 4 size we assinged
        }
        public Stack(int size)
        {
            _top=-1;
            _capacity=size;     // assing the capacisty value to size
            _array=new Type[_capacity];
        }

        public void Push(Type value)
        {
            if(_top+1==_capacity)
            {
                GrowSize();
            }
            _array[_top+1]=value;     //-1+1=0, 0th array  value assinge the value
            _top++;      // increse the top value;
        }

        void GrowSize()
        {
            _capacity=_capacity*2;  // incrse the capacity 
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_top+1;i++)
            {
                temp[i]=_array[i];      // we assingn array value to temp 
            }
            _array=temp;    // temp memory addrss to allowcate to _array



            
        }

        public Type Peek()
        {
            if(_top==-1)
            {
                return default(Type);
            }
            else{
                return  _array[_top];
            }
        }

        public Type Pop()
        {
            if(_top==-1)
            {
                return default(Type);
            }
            else{
                _top--;
                return _array[_top+1];
                
            }
        }


    }
}
