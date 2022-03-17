using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using LabMilesko5.ViewModels;

namespace LabMilesko5.Views
{
    public partial class RegexWindow : Window
    {
        public RegexWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            this.FindControl<Button>("OKButton").Click += async delegate
            {
                var contex = this.DataContext as MainWindowViewModel;
                contex.CompNew = contex.CompOld;
                Close();
            };

            this.FindControl<Button>("CancelButton").Click += async delegate
            {
                var contex = this.DataContext as MainWindowViewModel;
                contex.CompOld = contex.CompNew;
                Close();
            };
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
