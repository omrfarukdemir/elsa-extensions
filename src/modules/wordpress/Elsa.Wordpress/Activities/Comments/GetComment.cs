using Elsa.WordPress.Activities;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.Comments;

/// <summary>
/// Retrieves information about a comment by its ID.
/// </summary>
[Activity(
    "Elsa.Wordpress.Comments",
    "Wordpress Comments",
    "Retrieves information about a comment by its ID.",
    DisplayName = "Get Comment")]
[UsedImplicitly]
public class GetComment : WordPressActivity
{
    // Implementation for getting a comment
}