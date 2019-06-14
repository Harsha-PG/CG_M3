using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericStack
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // initialize the custom generic stack class
                MyGenericStack<int> ints = new MyGenericStack<int>(2);
                // push elements
                ints.Push(10);
                // push elements
                ints.Push(100); 
                // print the count               
                Console.WriteLine(ints.Count); 
                // check the top most element
                Console.WriteLine(ints.Peek());

                // remove element from the custom generic stack class
                Console.WriteLine(ints.Pop());
                Console.WriteLine(ints.Pop());                
                    
            }
            catch (StackException ex)
            {
                Console.WriteLine(ex.Message);                
            }
            
        }
    }
}
