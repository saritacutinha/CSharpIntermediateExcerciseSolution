using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var stack = new Stack();
            try
            {
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);

                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());

            }

            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
           
            
           
        }
    }
}
