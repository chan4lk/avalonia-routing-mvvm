// <copyright file="Extensions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Avalonia.Routing.App
{
    using Avalonia.Controls.ApplicationLifetimes;
    using Avalonia.Routing.App.ViewModels;

    public static class Extensions
    {
        public static MainWindowViewModel? GetMainWindowViewModel(this Application application)
        {
            if ((application.ApplicationLifetime as IClassicDesktopStyleApplicationLifetime)?.MainWindow is { } mainWindow)
            {
                var mainWindowVm = (MainWindowViewModel)mainWindow.DataContext!;
                return mainWindowVm;
            }

            return null;
        }
    }
}
