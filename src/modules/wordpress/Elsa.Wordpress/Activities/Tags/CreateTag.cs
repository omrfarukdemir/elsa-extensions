using Elsa.WordPress.Activities;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.Tags;

/// <summary>
/// Creates a new tag.
/// </summary>
[Activity(
    "Elsa.Wordpress.Tags",
    "Wordpress Tags",
    "Creates a new tag.",
    DisplayName = "Create Tag")]
[UsedImplicitly]
public class CreateTag : WordPressActivity
{
    // Implementation for creating a tag
}
