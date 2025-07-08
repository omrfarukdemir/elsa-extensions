using Elsa.WordPress.Activities;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.Posts;

/// <summary>
/// Updates a post specified by its ID.
/// </summary>
[Activity(
    "Elsa.Wordpress.Posts",
    "Wordpress Posts",
    "Updates a post specified by its ID.",
    DisplayName = "Update Post")]
[UsedImplicitly]
public class UpdatePost : WordPressActivity
{
    // Implementation for updating a post
}
