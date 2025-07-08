using Elsa.WordPress.Activities;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.Comments;

/// <summary>
/// Searches for specific comments.
/// </summary>
[Activity(
    "Elsa.Wordpress.Comments",
    "Wordpress Comments",
    "Searches for specific comments.",
    DisplayName = "Get Comment")]
[UsedImplicitly]
public class SearchComments : WordPressActivity
{
    // Implementation for searching comments
}
