using System.Collections.Generic;

namespace WorkFlowEngine
{
    public class WorkFlowEngine
    {
       
        public void Run(IWorkFlow workFlow)
        {
            System.Console.WriteLine("Running Tasks in the List");
            foreach(IActivity activity in workFlow.GetActivity())
            {
                activity.Execute();
            }
            System.Console.WriteLine("Sucessfully executed task list");
        }

        
    }
}
