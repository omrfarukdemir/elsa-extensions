using Elsa.WordPress.Activities;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.Posts;

/// <summary>
/// Searches for specific posts.
/// </summary>
[Activity(
    "Elsa.Wordpress.Posts",
    "Wordpress Posts",
    "Searches for specific posts.",
    DisplayName = "Search Post")]
[UsedImplicitly]
public class SearchPosts : WordPressActivity
{
    // Implementation for searching posts
}