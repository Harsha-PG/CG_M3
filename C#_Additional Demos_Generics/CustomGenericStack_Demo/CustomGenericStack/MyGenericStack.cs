using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericStack
{
    class MyGenericStack<T>
    {
        // Collection to hold the custom generic stack class items
        T[] items = null;

        // variable to store the max size of the custom generic stack class
        int maxSize = 0;

        // variable to store the current position
        int counter = 0;

        // Default constructor
        public MyGenericStack()
        {
            // setting maxsize to 10;
            maxSize = 10;
            // initializing the collection with maxsize
            items = new T[maxSize];
            // count is set to zero
            Count = 0;
        }

        // Parameterized constructor
        public MyGenericStack(int size)
        {
            // setting maxsize to user value;
            maxSize = size;
            // initializing the collection with maxsize
            items = new T[maxSize];
            // count is set to zero
            Count = 0;
        }

        // property to store the no of elements in the custom generic stack class
        public int Count { get; set; }

        // Push method to add elements into the custom generic stack class
        public void Push(T item)
        {
            // check if the counter has reached maxsize value or not
            if (counter < maxSize)
            {
                // add the element into the collection
                items[counter] = item;
                // increment counter by 1
                counter++;
                // increment count by 1
                Count++;
            }
            else
            {
                // throw exception
                throw new StackException("Custom generic stack class is full");
            }
        }

        // Pop method to remove elements from the custom generic stack class
        public T Pop()
        {
            if (counter <= 0)
            {
                throw new StackException("Custom generic stack class is empty");
            }
            else
            {
                // decrement the counter by 1
                counter--;
                // decrement the count by 1
                Count--;
                // return the top most element from the custom generic stack class
                return items[counter];
            }
        }

        // Peek method to show the top most element from the custom generic stack class
        public T Peek()
        {
            if (counter <= 0)
            {
                throw new StackException("Custom generic stack class is empty");
            }
            else
            {                
                // return the top most element from the custom generic stack class
                return items[counter-1];
            }
        }
    }
}
