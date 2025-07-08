using Elsa.Features.Abstractions;
using Elsa.Features.Services;

namespace Elsa.Wordpress.Features;

/// <summary>
/// Represents a feature for setting up Wordpress integration within the Elsa framework.
/// </summary>
public class WordpressFeature(IModule module) : FeatureBase(module)
{
    /// <summary>
    /// Applies the feature to the specified service collection.
    /// </summary>
    public override void Apply()
    {
        
    }
}