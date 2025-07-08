using Elsa.WordPress.Activities;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.Tags;

/// <summary>
/// Updates a tag specified by its ID.
/// </summary>
[Activity(
    "Elsa.Wordpress.Tags",
    "Wordpress Tags",
    "Updates a tag specified by its ID.",
    DisplayName = "Update Tag")]
[UsedImplicitly]
public class UpdateTag : WordPressActivity
{
    // Implementation for updating a tag
}
