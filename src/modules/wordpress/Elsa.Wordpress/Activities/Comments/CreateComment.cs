using Elsa.WordPress.Activities;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.Comments;

/// <summary>
/// Creates a new comment.
/// </summary>
[Activity(
    "Elsa.Wordpress.Comments",
    "Wordpress Comments",
    "Creates a new comment.",
    DisplayName = "Create Comment")]
[UsedImplicitly]
public class CreateComment : WordPressActivity
{
    // Implementation for creating a comment
}