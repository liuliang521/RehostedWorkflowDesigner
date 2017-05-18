namespace RehostedWorkflowDesigner.Execution
{
    public interface IWorkflowRunner
    {
        bool IsRunning { get; }

        void Abort();

        void Run();
    }
}
