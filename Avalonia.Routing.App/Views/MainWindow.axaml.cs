// <copyright file="MainWindow.axaml.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Avalonia.Routing.App.Views;

using System.ComponentModel;
using Avalonia.Controls;
using Avalonia.Routing.App.ViewModels;
using Splat;

/// <summary>
/// The main window.
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        DataContext = Locator.Current.GetService<MainWindowViewModel>();
        InitializeComponent();
    }

    protected override void OnClosing(CancelEventArgs e)
    {
        var vm = DataContext as MainWindowViewModel;
        var index = vm?.GetCurrentPageIndex();

        if (index == 1)
        {
            e.Cancel = true;
            vm?.NavigatePrevious();
        }

        base.OnClosing(e);
    }
}
