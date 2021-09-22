using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class Workflow : IWorkflow
    {
        public IList<IActivity> _activities;
        public Workflow()
        {
            this._activities = new List<IActivity>();
        }
        public void Add(IActivity activity)
        {
            this._activities.Add(activity);
        }
        public void Remove(IActivity activity)
        {
            this._activities.Remove(activity);
        }
        public IEnumerable<IActivity> GetActivities()
        {
            return this._activities;
        }
    }
}
