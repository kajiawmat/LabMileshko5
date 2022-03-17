using Avalonia.Controls;
using Avalonia.Interactivity;
using LabMilesko5.ViewModels;

namespace LabMilesko5.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.FindControl<Button>("OpenFile").Click += async delegate
            {
                var taskPathIn = new OpenFileDialog()
                {
                    Title = "Open file",
                    Filters = null
                }.ShowAsync((Window)this.VisualRoot);

                string[]? path = await taskPathIn;
                var contex = this.DataContext as MainWindowViewModel;
                if (path != null) contex.SetPath = string.Join(@"\", path);
            };

            this.FindControl<Button>("SaveFile").Click += async delegate
            {
                var taskPathOut = new SaveFileDialog()
                {
                    Title = "Choose file",
                    Filters = null
                }.ShowAsync((Window)this.VisualRoot);

                string? path2 = await taskPathOut;
                var contex = this.DataContext as MainWindowViewModel;
                if (path2 != null) contex.GetPath = path2;
            };


        }
        public void MyClickEventHandler(object sender, RoutedEventArgs e)
        {
            var w = new RegexWindow();
            w.DataContext = this.DataContext as MainWindowViewModel;
            w.ShowDialog((Window)this.VisualRoot);
        }
    }
}
