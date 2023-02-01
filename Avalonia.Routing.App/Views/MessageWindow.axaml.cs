// <copyright file="MessageWindow.axaml.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Avalonia.Routing.App.Views;

using Avalonia.Controls;
using Avalonia.Routing.App.ViewModels;
using Splat;

/// <summary>
/// The message window.
/// </summary>
public partial class MessageWindow : Window
{
    public MessageWindow()
    {
        DataContext = Locator.Current.GetService<MessageWindowViewModel>();
        InitializeComponent();
    }
}
