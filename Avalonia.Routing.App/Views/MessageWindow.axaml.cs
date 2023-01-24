using Avalonia.Controls;
using Avalonia.Routing.App.ViewModels;
using Splat;

namespace Avalonia.Routing.App.Views
{
    public partial class MessageWindow : Window
    {
        public MessageWindow()
        {
            DataContext = Locator.Current.GetService<MessageWindowViewModel>();
            InitializeComponent();
        }
    }
}
