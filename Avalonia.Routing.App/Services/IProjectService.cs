// <copyright file="IProjectService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Avalonia.Routing.App.Services
{
    using Avalonia.Routing.App.Models;

    public interface IProjectService
    {
        Project[] GetProjects();

        Project[] GetUpdatedProjects();
    }
}
