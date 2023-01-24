using Avalonia.Controls;
using Avalonia.Routing.App.ViewModels;
using Splat;

namespace Avalonia.Routing.App.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = Locator.Current.GetService<MainWindowViewModel>();
            InitializeComponent();
        }
    }
}