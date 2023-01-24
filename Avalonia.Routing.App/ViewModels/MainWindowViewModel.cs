using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Splat;
using System.Collections.Generic;
using System.Windows.Input;

namespace Avalonia.Routing.App.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {

        public MainWindowViewModel()
        {
            Pages = new List<PageViewModelBase>
            {
                Locator.Current.GetService<ProjectListViewModel>()!,
                Locator.Current.GetService<WizardViewModel>()!,
            };
            // Set current page to first on start up
            CurrentPage = Pages[0];
        }

        // A read.only array of possible pages
        private List<PageViewModelBase> Pages;

        /// <summary>
        /// Gets the current page. The property is read-only
        /// </summary>
        [ObservableProperty]
        public PageViewModelBase currentPage;


        [RelayCommand]
        public void NavigateNext()
        {
            // get the current index and add 1
            var index = Pages.IndexOf(currentPage) + 1;

            if (index < Pages.Count)
            {
                CurrentPage = Pages[index];
            }
        }

        [RelayCommand]
        public void NavigatePrevious()
        {
            // get the current index and subtract 1
            var index = Pages.IndexOf(currentPage) - 1;

            if (index > -1)
            {
                CurrentPage = Pages[index];
            }
        }

        public int GetCurrentPageIndex()
        {
            var index = Pages.IndexOf(currentPage);
            return index;
        }
    }
}