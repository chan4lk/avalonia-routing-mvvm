using CommunityToolkit.Mvvm.ComponentModel;

namespace Avalonia.Routing.App.ViewModels
{
    public partial class MessageWindowViewModel : ViewModelBase
    {
        [ObservableProperty]
        public string title = "Hi Dialog";
    }
}
