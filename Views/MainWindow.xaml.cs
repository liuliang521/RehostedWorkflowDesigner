namespace RehostedWorkflowDesigner.Views
{
    using System.ComponentModel;
    using System.Windows;
    using RehostedWorkflowDesigner.Utilities;
    using RehostedWorkflowDesigner.ViewModel;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();

            this.viewModel = new MainWindowViewModel(this.DockManager, this.HorizontalResizingPanel, this.VerticalResizingPanel, this.TabsPane);
            this.DataContext = this.viewModel;
            Status.DataContext = StatusViewModel.GetInstance;
            DispatcherService.DispatchObject = this.Dispatcher;
            this.Closing += new CancelEventHandler(this.viewModel.Closing);
        }
    }
}