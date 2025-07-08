using Elsa.WordPress.Activities;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.Posts;

/// <summary>
/// Creates a new post.
/// </summary>
[Activity(
    "Elsa.Wordpress.Posts",
    "Wordpress Posts",
    "Creates a new post.",
    DisplayName = "Create Post")]
[UsedImplicitly]
public class CreatePost : WordPressActivity
{
    // Implementation for creating a post
}
