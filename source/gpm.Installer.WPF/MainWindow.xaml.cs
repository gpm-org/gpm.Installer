using System.Threading.Tasks;
using System.Windows;
using CommunityToolkit.Mvvm.DependencyInjection;
using gpm.Core.Services;
using Serilog;

namespace gpm.Installer.WPF;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    // bad
    private async void Window_Loaded(object sender, RoutedEventArgs e)
    {
        var _mainController = Ioc.Default.GetRequiredService<MainController>();

        if (!await Task.Run(() => _mainController.RunAsync()))
        {
            Log.Warning("Installation failed.");
        }
        else
        {
            Log.Information("Installation finished succesfully.");
        }

        //Application.Current.Shutdown();
    }
}
