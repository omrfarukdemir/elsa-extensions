using Elsa.WordPress.Activities;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.Users;

/// <summary>
/// Deletes a user specified by its ID.
/// </summary>
[Activity(
    "Elsa.Wordpress.Users",
    "Wordpress Users",
    "Deletes a user specified by its ID.",
    DisplayName = "Delete User")]
[UsedImplicitly]
public class DeleteUser : WordPressActivity
{
    // Implementation for deleting a user
}