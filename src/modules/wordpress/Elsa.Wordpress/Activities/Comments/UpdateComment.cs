using Elsa.WordPress.Activities;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.Comments;

/// <summary>
/// Updates a comment specified by its ID.
/// </summary>
[Activity(
    "Elsa.Wordpress.Comments",
    "Wordpress Comments",
    "Updates a comment specified by its ID.",
    DisplayName = "Update Comment")]
[UsedImplicitly]
public class UpdateComment : WordPressActivity
{
    // Implementation for updating a comment
}