// <copyright file="AdvancedTabViewModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Avalonia.Routing.App.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;

/// <summary>
/// The advanced tab view model.
/// </summary>
public partial class AdvancedTabViewModel : ViewModelBase
{
    [ObservableProperty]
    private string title = "This is a nested user control";
}
