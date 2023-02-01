// <copyright file="MainWindowViewModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Avalonia.Routing.App.ViewModels
{
    using System.Collections.Generic;
    using CommunityToolkit.Mvvm.ComponentModel;
    using CommunityToolkit.Mvvm.Input;
    using Splat;

    /// <summary>
    /// The main window.
    /// </summary>
    public partial class MainWindowViewModel : ViewModelBase
    {
        // A read.only array of possible pages
        private readonly List<PageViewModelBase> pages;

        [ObservableProperty]
        private PageViewModelBase? currentPage;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindowViewModel"/> class.
        /// </summary>
        public MainWindowViewModel()
        {
            pages = new List<PageViewModelBase>
            {
                Locator.Current.GetService<ProjectListViewModel>() !,
                Locator.Current.GetService<WizardViewModel>() !,
            };

            // Set current page to first on start up
            CurrentPage = pages[0];
        }

        [RelayCommand]
        public void NavigateNext()
        {
            if (currentPage != null)
            {
                // get the current index and add 1
                var index = pages.IndexOf(currentPage) + 1;

                if (index < pages.Count)
                {
                    CurrentPage = pages[index];
                }
            }
        }

        [RelayCommand]
        public void NavigatePrevious()
        {
            if (currentPage != null)
            {
                // get the current index and subtract 1
                var index = pages.IndexOf(currentPage) - 1;

                if (index > -1)
                {
                    CurrentPage = pages[index];
                }
            }
        }

        public int GetCurrentPageIndex()
        {
            if (currentPage != null)
            {
                var index = pages.IndexOf(currentPage);
                return index;
            }

            return -1;
        }
    }
}
