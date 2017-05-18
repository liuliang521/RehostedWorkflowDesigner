namespace RehostedWorkflowDesigner.Execution
{
    using System.Windows;

    public interface IWorkflowDebugger : IWorkflowRunner
    {
        UIElement GetDebugView();
    }
}
