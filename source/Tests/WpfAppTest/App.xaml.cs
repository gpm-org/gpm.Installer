using System.Windows;
using CommunityToolkit.Mvvm.DependencyInjection;
using gpm.Installer;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace WpfAppTest;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public App()
    {
        // Register services
        Ioc.Default.ConfigureServices(
            new ServiceCollection()

            .AddSingleton<MySink>()

            .AddGpmInstaller()

            .BuildServiceProvider());

        Log.Logger = new LoggerConfiguration()
          .MinimumLevel.Debug()
          .WriteTo.Console()
          .WriteTo.MySink()
          .CreateLogger();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        Log.Information("Started");
    }



}
