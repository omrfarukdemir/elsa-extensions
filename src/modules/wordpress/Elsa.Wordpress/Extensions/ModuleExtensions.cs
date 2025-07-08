using Elsa.Wordpress.Features;
using Elsa.Features.Services;

// ReSharper disable once CheckNamespace
namespace Elsa.Extensions;

/// <summary>
/// Extends <see cref="IModule"/> with methods to use Wordpress integration.
/// </summary>
public static class ModuleExtensions
{
    /// <summary>
    /// Installs the Wordpress feature.
    /// </summary>
    public static IModule UseGitHub(this IModule module, Action<WordpressFeature>? configure = null)
    {
        return module.Use(configure);
    }
}