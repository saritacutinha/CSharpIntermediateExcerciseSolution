using System.Collections.Generic;

namespace WorkFlowEngine
{
    public class WorkFlowEngine
    {
        private readonly IList<IActivity> _activities;

        public WorkFlowEngine()
        {
            _activities = new List<IActivity>();
        }
        public void Run()
        {
            System.Console.WriteLine("Workflow Engine Start");
            foreach(var activity in _activities)
            {
                activity.Execute();
            }
            System.Console.WriteLine("WorkFlow engine Stop");
        }

        public void RegisterWorkFlow(IActivity activity)
        {
            _activities.Add(activity);
        }
    }
}
