using System;
using System.Collections.Generic;
using System.Text;

namespace CreateMyList
{
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];  //çağrıldığında 0 uzunluğunda bir array oluşturduk.
        }

        public void Add(T item)
        {
            T[] tempItems = items;  //geçici arrayimizi oluşturduk.

            items = new T[items.Length + 1]; 

            for (int i = 0; i < tempItems.Length; i++) // geçici arrayda olan bilgileri gerçek arrayimize atadık.
            {
                items[i] = tempItems[i];
            }
            items[items.Length - 1] = item;
        }
        public T[] Items // yazdırma işlemi
        {
            get { return items; }
        }

        public int Length //uzunluğunu bulma işlemi
        {
            get { return items.Length; }
        }
    }
}
