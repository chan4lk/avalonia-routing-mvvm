using Avalonia.Routing.App.Models;

namespace Avalonia.Routing.App.Services
{
    public interface IProjectService
    {
        Project[] GetProjects();
        Project[] GetUpdatedProjects();
    }

    public class ProjectService : IProjectService
    {
        public Project[] GetProjects()
        {
            return new Project[] { new Project() { Id = 1, Name = "Test 1", Description = "Test Project 1" } };
        }

        public Project[] GetUpdatedProjects()
        {
            return new Project[] { new Project() { Id = 2, Name = "Test 2", Description = "Test Project 2" } };
        }
    }
}
