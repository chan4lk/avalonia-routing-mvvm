using Avalonia.Collections;
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

        public ProjectListViewModel(IProjectService projectService)
        {
            this.Projects = new DataGridCollectionView(projectService.GetProjects());
        }

        [RelayCommand]
        void Upload()
        {
            _mainWindowVm = Application.Current.GetMainWindowViewModel();
            _mainWindowVm?.NavigateNext();
        }
    }
}
