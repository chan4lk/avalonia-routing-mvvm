using Avalonia.Collections;
using Avalonia.Routing.App.Models;
using Avalonia.Routing.App.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System;

namespace Avalonia.Routing.App.ViewModels
{
    /// <summary>
    ///  This is our ViewModel for the first page
    /// </summary>
    public partial class ProjectListViewModel : PageViewModelBase
    {
        private readonly IProjectService projectService;

        /// <summary>
        /// The Title of this page
        /// </summary>
        public string Title => "Improt Project(s) to Azure Sites";

        /// <summary>
        /// The projects.
        /// </summary>
        [ObservableProperty]
        public DataGridCollectionView projects;

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
            this.projectService = projectService;
            this.projects = new DataGridCollectionView(projectService.GetProjects());
        }
    }
}
