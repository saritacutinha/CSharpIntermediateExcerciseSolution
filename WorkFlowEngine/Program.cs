using System;

namespace WorkFlowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Workflow Engine");
            WorkFlowEngine workflow = new WorkFlowEngine();
            workflow.RegisterWorkFlow(new ReadDataActivity());
            workflow.RegisterWorkFlow(new AnalyseDataActivity());
            workflow.RegisterWorkFlow(new WriteDataActivity());

            workflow.Run();
        }
    }
}
