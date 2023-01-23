using Avalonia.Controls;
using Avalonia.Routing.App.Models;
using System.Collections.Generic;

namespace Avalonia.Routing.App.Views
{
    public partial class ProjectListView : UserControl
    {
        public IList<Project> Projects { get; set; }

        public ProjectListView()
        {
            Projects = new List<Project>() { new Project() { Id = 1, Name = "Test 1", Description = "Test Project 1" } };
            InitializeComponent();
        }
    }
}
