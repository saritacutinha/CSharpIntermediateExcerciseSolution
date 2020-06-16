using System;
using System.Collections.Generic;

namespace Stack
{
    public class Stack
    {
        private List<object> stackList = new List<object>();
        public void Push(object obj)
        {

            if (obj != null)
            {
                stackList.Add(obj);
                Console.WriteLine("Added :{0}", obj);
            }
            else
                throw new InvalidOperationException("Object cannot be added");

        }

        public object Pop()
        {
            if (stackList.Count != 0)
            {

                var pop = stackList[stackList.Count - 1];
                stackList.Remove(stackList[stackList.Count - 1]);
                return pop;

            }
           else
                throw new InvalidOperationException("Object cannot be removed");
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
