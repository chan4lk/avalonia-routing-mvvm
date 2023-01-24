using CommunityToolkit.Mvvm.ComponentModel;
using Splat;
using System;

namespace Avalonia.Routing.App.ViewModels
{
    /// <summary>
    ///  This is our ViewModel for the third page
    /// </summary>
    public partial class WizardViewModel : PageViewModelBase
    {
        // The message to display
        public string Message => "Done";

        [ObservableProperty]
        public AdvancedTabViewModel advancedTabViewModel;

        public WizardViewModel()
        {
            AdvancedTabViewModel = Locator.Current.GetService<AdvancedTabViewModel>();
        }
    }
}
