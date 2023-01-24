using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Routing.App.Models;
using Avalonia.Routing.App.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;

namespace Avalonia.Routing.App.ViewModels
{
    /// <summary>
    ///  This is our ViewModel for the first page
    /// </summary>
    public partial class ProjectListViewModel : PageViewModelBase
    {
        private MainWindowViewModel? mainWindowVm;

        /// <summary>
        /// The Title of this page
        /// </summary>
        public string Title => "Improt Project(s) to Azure Sites";

        /// <summary>
        /// The projects.
        /// </summary>
        [ObservableProperty]
        public DataGridCollectionView projects;

        private readonly IProjectService projectService;

        /// <summary>
        /// The content of this page
        /// </summary>
        public string Message => "Press \"Next\" to register yourself.";

        // This is our first page, so we can navigate to the next page in any case
        public override bool CanNavigateNext
        {
            get => true;
            protected set => throw new NotSupportedException();
        }

        // You cannot go back from this page
        public override bool CanNavigatePrevious
        {
            get => false;
            protected set => throw new NotSupportedException();
        }

        public ProjectListViewModel(IProjectService projectService)
        {
            this.projects = new DataGridCollectionView(projectService.GetProjects());
            if ((Application.Current?.ApplicationLifetime as IClassicDesktopStyleApplicationLifetime)?.MainWindow is { } mainWindow)
            {
                mainWindowVm = (MainWindowViewModel)mainWindow.DataContext!;
            }

            this.projectService = projectService;
        }

        [RelayCommand]
        void Upload()
        {  
            this.projects = new DataGridCollectionView(projectService?.GetUpdatedProjects());
            //mainWindowVm?.NavigateNext();
        }
    }
}
