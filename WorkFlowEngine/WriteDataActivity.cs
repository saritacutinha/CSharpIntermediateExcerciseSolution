using System;

namespace WorkFlowEngine
{
    public class WriteDataActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Writing Data Activity ..");
        }
    }
}
