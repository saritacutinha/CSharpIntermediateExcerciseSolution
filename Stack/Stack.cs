using System;
using System.Collections.Generic;

namespace Stack
{
    public class Stack
    {
        List<object> stackList = new List<object>();
        public void Push(object obj)
        {

            if (obj == null)           
                throw new InvalidOperationException("Object cannot be added"); 
            
            stackList.Add(obj);
            Console.WriteLine("Added :{0}", obj);
        }

        public object Pop()
        {
            if (stackList.Count == 0)
                throw new InvalidOperationException("Object cannot be removed");

            var pop = stackList[stackList.Count - 1];
            stackList.Remove(stackList[stackList.Count - 1]);
            return pop;
        }                

        public void Clear()
        {
           if(stackList.Count!=0)
            {
                stackList.Clear();
            }
            Console.WriteLine("Stack is cleared");
        }
    }
}
