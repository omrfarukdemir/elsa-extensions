using Elsa.WordPress.Activities;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.Users;

/// <summary>
/// Retrieves information about a user by its ID.
/// </summary>
[Activity(
    "Elsa.Wordpress.Users",
    "Wordpress Users",
    "Retrieves information about a user by its ID.",
    DisplayName = "Get User")]
[UsedImplicitly]
public class GetUser : WordPressActivity
{
    // Implementation for getting a user
}