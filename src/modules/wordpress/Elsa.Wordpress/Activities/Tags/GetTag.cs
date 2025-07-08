using Elsa.WordPress.Activities;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.Tags;

/// <summary>
///  Retrieves information about a tag by its ID.
/// </summary>
[Activity(
    "Elsa.Wordpress.Tags",
    "Wordpress Tags",
    " Retrieves information about a tag by its ID.",
    DisplayName = "Get Tag")]
[UsedImplicitly]
public class GetTag : WordPressActivity
{
    // Implementation for getting a tag
}
