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
