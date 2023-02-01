// <copyright file="ProjectListViewModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Avalonia.Routing.App.ViewModels;

using System;
using Avalonia.Collections;
using Avalonia.Routing.App.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

/// <summary>
///  This is our ViewModel for the first page.
/// </summary>
public partial class ProjectListViewModel : PageViewModelBase
{
    private MainWindowViewModel? mainWindowVm;

    /// <summary>
    /// The Title of this page.
    /// </summary>
    [ObservableProperty]
    private string title = "Improt Project(s) to Azure Sites";

    /// <summary>
    /// The projects.
    /// </summary>
    [ObservableProperty]
    private DataGridCollectionView projects;

    public ProjectListViewModel(IProjectService projectService)
    {
        this.projects = new DataGridCollectionView(projectService.GetProjects());
    }

    [RelayCommand]
    private void Upload()
    {
        mainWindowVm = Application.Current?.GetMainWindowViewModel();
        mainWindowVm?.NavigateNext();
    }
}
