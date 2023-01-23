using Avalonia.Routing.App.Models;
using System;
using System.Collections.Generic;

namespace Avalonia.Routing.App.ViewModels
{
    /// <summary>
    ///  This is our ViewModel for the first page
    /// </summary>
    public class ProjectListViewModel : PageViewModelBase
    {
        /// <summary>
        /// The Title of this page
        /// </summary>
        public string Title => "Improt Project(s) to Azure Sites";

        /// <summary>
        /// The projects.
        /// </summary>
        public Project[] Projects { get; set; } = new Project[] { new Project() { Id = 1, Name = "Test 1", Description = "Test Project 1" } };

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
    }
}
