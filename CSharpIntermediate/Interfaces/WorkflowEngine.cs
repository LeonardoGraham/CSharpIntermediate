namespace CSharpIntermediate
{
    public class WorkflowEngine
    {
        private readonly IWorkflow _workflow;

        public WorkflowEngine(IWorkflow workflow) 
        {
            this._workflow = workflow;
        }
        public void Run()
        {
            foreach(var activity in this._workflow.GetActivities())
            {
                activity.Execute();
            }
        }
    }
}
