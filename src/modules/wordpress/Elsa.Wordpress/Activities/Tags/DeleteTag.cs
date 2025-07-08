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
    "Deletes a tag specified by its ID.",
    DisplayName = "Delete Tag")]
[UsedImplicitly]

public class DeleteTag : WordPressActivity
{
    // Implementation for deleting a tag
}
