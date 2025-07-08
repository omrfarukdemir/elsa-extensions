using Elsa.WordPress.Activities;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.Comments;

/// <summary>
/// Deletes a comment specified by its ID.
/// </summary>
[Activity(
    "Elsa.Wordpress.Comments",
    "Wordpress Comments",
    "Deletes a comment specified by its ID.",
    DisplayName = "Delete Comment")]
[UsedImplicitly]

public class DeleteComment : WordPressActivity
{
    // Implementation for deleting a comment
}
