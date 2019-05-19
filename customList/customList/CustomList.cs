using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customList
{
    public class CustomList<T>: IEnumerable
    {
        //member variables

        public T[] items;
        private T[] newItems;
        public int count;
        public int Count { get { return count; } }        
        private int capacity;
        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }
        //constructor
        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];            
        }
        //member methods
        public void Add(T item)
        {            
            if (count == capacity)
            {
                capacity += capacity;
                newItems = new T[capacity];
                for (int i = 0; i < count; i++)
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

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }
        public override string ToString()
        {
            string newString = "";
            for (int i = 0; i < count; i++)
            {
                newString += items[i] + " ";                
            }
            string result = newString.Trim();
            return result;
        }
        public static CustomList<T> operator +(CustomList<T> one, CustomList<T>two)
        {
            CustomList<T> customList = new CustomList<T>();
            foreach (T element in one)
            {
                customList.Add(element);
            }
            foreach (T element in two)
            {
                customList.Add(element);
            }
            return customList;
        }
        public static CustomList<T> operator -(CustomList<T> one, CustomList<T> two)
        {
            CustomList<T> customList = new CustomList<T>();
            foreach (T element1 in one)
            {
                customList.Add(element1);
                foreach (T element2 in two)
                {                    
                    if (element2.Equals(element1))
                    {
                        customList.Remove(element1);                        
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return customList;
        }
        public static CustomList<T> operator Zip()
        {

        }
    }    
}
