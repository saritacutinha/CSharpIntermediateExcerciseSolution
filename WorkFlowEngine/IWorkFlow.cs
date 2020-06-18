using System.Collections.Generic;

namespace WorkFlowEngine
{
    public interface IWorkFlow
    {
        void AddActivity(IActivity activity);
        void RemoveActivity(IActivity activity);

        IEnumerable<IActivity> GetActivity();
        
    }
}
