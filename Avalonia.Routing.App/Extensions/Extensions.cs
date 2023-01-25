using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Routing.App.ViewModels;

namespace Avalonia.Routing.App
{
    public static class Extensions
    {
        public static MainWindowViewModel GetMainWindowViewModel(this Application application)
        {
            if ((application.ApplicationLifetime as IClassicDesktopStyleApplicationLifetime)?.MainWindow is { } mainWindow)
            {
                var _mainWindowVm = (MainWindowViewModel)mainWindow.DataContext!;
                return _mainWindowVm;
            }

            return null;
        }
    }
}
