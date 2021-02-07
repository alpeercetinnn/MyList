using System;
using System.Collections.Generic;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> plakalar = new List<int>();         //my reference

            MyDictionary<int> plakalar2 = new MyDictionary<int>();
            plakalar2.Add(01);
            plakalar2.Add(02);
            plakalar2.Add(03);
            plakalar2.Add(04);
            plakalar2.Add(05);

        }

        class MyDictionary<T>
        {
            T[] _array;
            T[] _temparray; 
            public MyDictionary()
            {
                _array = new T[0];
            }
            public void Add(T item)
            {
                _temparray = _array;

                _array = new T[_array.Length+1];

                for (int i = 0; i < _temparray.Length; i++)
                {
                    _array[i] = _temparray[i];
                }

                _array[_array.Length - 1] = item;
            }
        }
    }
}
