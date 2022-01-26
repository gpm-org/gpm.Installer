using gpm.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace gpm.Installer;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds all gpm internal dependencies
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddGpmInstaller(this IServiceCollection services)
    {
        services.AddSingleton<IArchiveService, ArchiveService>();
        services.AddSingleton<ILibraryService, LibraryService>();
        services.AddSingleton<IDataBaseService, DataBaseService>();
        services.AddSingleton<IDeploymentService, DeploymentService>();
        services.AddSingleton<IGitHubService, GitHubService>();
        services.AddSingleton<ITaskService, TaskService>();

        services.AddSingleton<AutoInstallerService>();

        return services;
    }
}
