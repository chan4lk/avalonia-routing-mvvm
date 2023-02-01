// <copyright file="MessageWindowViewModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Avalonia.Routing.App.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;

/// <summary>
/// The main view model.
/// </summary>
public partial class MessageWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private string title = "Hi Dialog";
}
