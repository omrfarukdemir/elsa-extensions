using Elsa.WordPress.Activities;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.Posts;

/// <summary>
/// Deletes a post specified by its ID.
/// </summary>
[Activity(
    "Elsa.Wordpress.Posts",
    "Wordpress Posts",
    "Deletes a post specified by its ID.",
    DisplayName = "Delete Post")]
[UsedImplicitly]
public class DeletePost : WordPressActivity
{
    // Implementation for deleting a post
}