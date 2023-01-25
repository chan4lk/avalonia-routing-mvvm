using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Headless;
using Avalonia.Routing.App.Views;
using Avalonia.Threading;
using Splat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalonia.Routing.App.UITests.Common
{

    public static class AvaloniaApp
    {
        public static void RegisterDependencies()
        {
            var services = Locator.CurrentMutable;
        }

        public static void Stop()
        {
            var app = GetApp();
            if (app is IDisposable disposable)
            {
                Dispatcher.UIThread.Post(disposable.Dispose);
            }

            Dispatcher.UIThread.Post(() => app.Shutdown());
        }

        public static MainWindow GetMainWindow() => (MainWindow)GetApp().MainWindow;

        public static IClassicDesktopStyleApplicationLifetime GetApp() =>
            (IClassicDesktopStyleApplicationLifetime)Application.Current.ApplicationLifetime;

        public static AppBuilder BuildAvaloniaApp() =>
            AppBuilder
                .Configure<App>()
                .UsePlatformDetect()
                .UseHeadless();
    }
}
