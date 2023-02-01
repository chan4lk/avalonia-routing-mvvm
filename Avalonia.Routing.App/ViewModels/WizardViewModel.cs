// <copyright file="WizardViewModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Avalonia.Routing.App.ViewModels;

using System;
using CommunityToolkit.Mvvm.ComponentModel;
using Splat;

/// <summary>
///  This is our ViewModel for the third page.
/// </summary>
public partial class WizardViewModel : PageViewModelBase
{
    [ObservableProperty]
    private AdvancedTabViewModel? advancedTabViewModel;

    public WizardViewModel()
    {
        AdvancedTabViewModel = Locator.Current.GetService<AdvancedTabViewModel>();
    }

    // The message to display
    public string Message => "Done";
}
