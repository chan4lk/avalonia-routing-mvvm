using CommunityToolkit.Mvvm.ComponentModel;

namespace Avalonia.Routing.App.ViewModels
{
    public partial class AdvancedTabViewModel : ViewModelBase
    {
        [ObservableProperty]
        public string title = "This is a nested user control";
    }
}
