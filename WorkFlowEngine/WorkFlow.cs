using System;
using System.Collections.Generic;

namespace WorkFlowEngine
{
    partial class Program
    {
        public class WorkFlow : IWorkFlow
        {
            private readonly IList<IActivity> _activities;

            public WorkFlow()
            {
                _activities = new List<IActivity>();
            }
            public void AddActivity(IActivity activity)
            {
                if (activity == null)
                    throw new InvalidOperationException("Add valid Activity");
                _activities.Add(activity);
            }

            public IEnumerable<IActivity> GetActivity()
            {
                return _activities;
            }

            public void RemoveActivity(IActivity activity)
            {
                if (activity == null)
                    throw new InvalidOperationException("Remove valid activity");
                _activities.Remove(activity);
                Console.WriteLine("{0} successfully removed", activity);
            }
        }
    }
}
