using Avalonia.Controls;
using Avalonia.Routing.App.ViewModels;
using Splat;
using System.ComponentModel;

namespace Avalonia.Routing.App.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = Locator.Current.GetService<MainWindowViewModel>();
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            var vm = DataContext as MainWindowViewModel;
            var index = vm?.GetCurrentPageIndex();

            if (index == 1)
            {
                e.Cancel = true;
                vm.NavigatePrevious();
            }

            base.OnClosing(e);
        }
    }
}