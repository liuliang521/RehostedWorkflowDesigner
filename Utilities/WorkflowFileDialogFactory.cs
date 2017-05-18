namespace RehostedWorkflowDesigner.Utilities
{
    using Microsoft.Win32;
    
    public class WorkflowFileDialogFactory
    {
        public static SaveFileDialog CreateSaveFileDialog(string defaultFilename)
        {
            var fileDialog = new SaveFileDialog();
            fileDialog.DefaultExt = "xaml";
            fileDialog.FileName = defaultFilename;
            fileDialog.Filter = "xaml files (*.xaml,*.xamlx)|*.xaml;*.xamlx;|All files (*.*)|*.*";
            return fileDialog;
        }

        public static OpenFileDialog CreateOpenFileDialog()
        {
            var fileDialog = new OpenFileDialog();
            fileDialog.DefaultExt = "xaml";
            fileDialog.Filter = "xaml files (*.xaml,*.xamlx)|*.xaml;*.xamlx;|All files (*.*)|*.*";
            return fileDialog;
        }

        public static OpenFileDialog CreateAddReferenceDialog()
        {
            var fileDialog = new OpenFileDialog();
            fileDialog.DefaultExt = "dll";
            fileDialog.Filter = "assembly files (*.dll)|*.dll;|All files (*.*)|*.*";
            return fileDialog;
        }
    }
}