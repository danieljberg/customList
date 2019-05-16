using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customList
{
    public class CustomList<T>
    {
        //member variables

        public T[] items;
        private T[] newItems;
        public int Count { get { return count; } }
        private int count;
        private int capacity;
        //constructor
        public CustomList()
        {
            capacity = 4;
            items = new T[capacity];
            count = 0;
        }
        

        //member methods
        public void Add(T item)
        {            
            if (count == capacity)
            {
                capacity += capacity;
                newItems = new T[capacity];
                for (int i = 0; i < capacity/2; i++)
                {
                    newItems[i] = items[i];
                }
                items = newItems;
            }
            items[count] = item;
            count++;
        }
        public void Remove(T item)
        {
            count--;
            newItems = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item))
                {
                    newItems[i] = (items[i + 1]);
                    for (int j = i + 1; j < count; j++)
                    {
                        newItems[j] = items[j + 1];                        
                    }
                    items = newItems;
                    break;
                }
                else
                {
                    newItems[i] = items[i];
                }               
            }
        }
    }
}
