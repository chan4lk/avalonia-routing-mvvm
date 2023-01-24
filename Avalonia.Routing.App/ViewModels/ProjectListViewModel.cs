using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Routing.App.Models;
using Avalonia.Routing.App.Services;
using Avalonia.Routing.App.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Splat;
using System;
using System.Threading.Tasks;

namespace Avalonia.Routing.App.ViewModels
{
    /// <summary>
    ///  This is our ViewModel for the first page
    /// </summary>
    public partial class ProjectListViewModel : PageViewModelBase
    {
        private MainWindowViewModel? _mainWindowVm;

        /// <summary>
        /// The Title of this page
        /// </summary>
        [ObservableProperty]
        public string title = "Improt Project(s) to Azure Sites";

        /// <summary>
        /// The projects.
        /// </summary>
        [ObservableProperty]
        public DataGridCollectionView projects;

        private readonly IProjectService projectService;

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
            this.projectService = projectService;
            this.Projects = new DataGridCollectionView(projectService.GetProjects());
        }

        [RelayCommand]
        void Upload()
        {
            if ((Application.Current?.ApplicationLifetime as IClassicDesktopStyleApplicationLifetime)?.MainWindow is { } mainWindow)
            {
                _mainWindowVm = (MainWindowViewModel)mainWindow.DataContext!;
            }
            _mainWindowVm?.NavigateNext();
        }
    }
}
