using Avalonia.Routing.App.Models;

namespace Avalonia.Routing.App.Services
{
    public interface IProjectService
    {
        Project[] GetProjects();
    }

    public class ProjectService : IProjectService
    {
        public Project[] GetProjects()
        {
            return new Project[] { new Project() { Id = 1, Name = "Test 1", Description = "Test Project 1" } };
        }
    }
}
