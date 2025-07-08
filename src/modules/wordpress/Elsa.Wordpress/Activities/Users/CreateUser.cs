using Elsa.WordPress.Activities;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.Users;

/// <summary>
/// Creates a new user.
/// </summary>
[Activity(
    "Elsa.Wordpress.Users",
    "Wordpress Users",
    "Creates a new user.",
    DisplayName = "Create User")]
[UsedImplicitly]
public class CreateUser : WordPressActivity
{
    // Implementation for creating a user
}