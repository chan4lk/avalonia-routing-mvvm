// <copyright file="App.axaml.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Avalonia.Routing.App
{
    using System;
    using Avalonia;
    using Avalonia.Controls.ApplicationLifetimes;
    using Avalonia.Data.Core;
    using Avalonia.Data.Core.Plugins;
    using Avalonia.Markup.Xaml;
    using Avalonia.Routing.App.Services;
    using Avalonia.Routing.App.ViewModels;
    using Avalonia.Routing.App.Views;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Splat;
    using Splat.Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// The Main App.
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider? Container { get; private set; }

        public IHost? Host { get; set; }

        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            Host = Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder()
              .ConfigureServices((_, services) =>
              {
                  services.UseMicrosoftDependencyResolver();
                  var resolver = Locator.CurrentMutable;
                  resolver.InitializeSplat();

                  ConfigureServices(services);
              })
              .Build();

            Container = Host.Services;
            Container.UseMicrosoftDependencyResolver();

            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                // Line below is needed to remove Avalonia data validation.
                // Without this line you will get duplicate validations from both Avalonia and CT
                ExpressionObserver.DataValidators.RemoveAll(x => x is DataAnnotationsValidationPlugin);
                desktop.MainWindow =
                           Locator.Current.GetService<MainWindow>();
            }

            base.OnFrameworkInitializationCompleted();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<MainWindow>();
            services.AddTransient<MainWindowViewModel>();

            services.AddTransient<MessageWindow>();
            services.AddTransient<MessageWindowViewModel>();

            services.AddTransient<ProjectListViewModel>();
            services.AddTransient<WizardViewModel>();
            services.AddTransient<AdvancedTabViewModel>();

            services.AddTransient<IProjectService, ProjectService>();
        }
    }
}
