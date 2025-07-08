using Elsa.WordPress.Activities;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.Posts;

/// <summary>
/// Retrieves information about a post by its ID.
/// </summary>
[Activity(
    "Elsa.Wordpress.Posts",
    "Wordpress Posts",
    "Retrieves information about a post by its ID.",
    DisplayName = "Get Post")]
[UsedImplicitly]
public class GetPost : WordPressActivity
{
    // Implementation for getting a post
}