using System;
using System.Collections;

namespace WorkFlowEngine
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adding Workflow");
            WorkFlow workFlow = new WorkFlow();
            workFlow.AddActivity(new ReadDataActivity());
            workFlow.AddActivity(new AnalyseDataActivity());
            workFlow.AddActivity(new WriteDataActivity());
            Console.WriteLine("Activities are successfully added to the workflow");

            Console.WriteLine("Running Workflow");
            WorkFlowEngine workFlowEngine = new WorkFlowEngine();
            workFlowEngine.Run(workFlow);

            Console.WriteLine("Removing Write Data Activity");
            workFlow.RemoveActivity(new WriteDataActivity());       
          
         }
    }
}
